namespace GardenTest;

public enum WaterState
{
    UNKNOWN,
    NEED_WATER,
    MOVE_VALVE,
    USE_PIPE,
    WATER_OK_PIPE,
    WATER_OK_ZIST,
    SWITCH_WATER_OFF,
    WATER_OFF
}

public class WaterSupply
{
    public event EventHandler<bool>? OnPump;
    public event EventHandler<bool>? OnValve;

    private bool _waterLevel = false;
    private WaterState _currentWaterState = WaterState.UNKNOWN;
    private DateTime _valveMoveStartet;

    public void WaterLevel(bool good) => _waterLevel = good;

    public void SwitchWaterOn()
    {
        _currentWaterState = WaterState.NEED_WATER;
    }

    public WaterState CheckWaterSupplyState()
    {
        if (_currentWaterState == WaterState.UNKNOWN || _currentWaterState == WaterState.WATER_OFF) return _currentWaterState;

        if (_currentWaterState == WaterState.NEED_WATER)
        {
            if (_waterLevel)
            {
                _currentWaterState = WaterState.MOVE_VALVE;
                OnValve?.Invoke(this, false);
            }
            else
            {
                _currentWaterState = WaterState.USE_PIPE;
                OnValve?.Invoke(this, true);
            }
            _valveMoveStartet = DateTime.Now;
            return _currentWaterState;
        }

        if (_currentWaterState == WaterState.MOVE_VALVE || _currentWaterState == WaterState.USE_PIPE)
        {
            if (DateTime.Now.Subtract(_valveMoveStartet) < TimeSpan.FromSeconds(10))
            {
                return _currentWaterState;
            }
            else
            {
                _valveMoveStartet = default;
                if (_currentWaterState == WaterState.MOVE_VALVE)
                {
                    OnPump?.Invoke(this, true);
                    _currentWaterState = WaterState.WATER_OK_ZIST;
                } else
                {
                    _currentWaterState = WaterState.WATER_OK_PIPE;
                }
                
                return _currentWaterState;
            }
        }

        if(_currentWaterState == WaterState.SWITCH_WATER_OFF)
        {
            if (_valveMoveStartet == default)
            {
                OnPump?.Invoke(this, false);
                OnValve?.Invoke(this, false);
                _valveMoveStartet = DateTime.Now;
                return WaterState.MOVE_VALVE;
            }

            if (DateTime.Now.Subtract(_valveMoveStartet) < TimeSpan.FromSeconds(10))
            {
                return WaterState.MOVE_VALVE;
            }

            _currentWaterState = WaterState.WATER_OFF;
            return _currentWaterState;
        }

        if(_currentWaterState == WaterState.WATER_OK_ZIST)
        {
            if(!_waterLevel)
            {
                _currentWaterState = WaterState.USE_PIPE;
                OnPump?.Invoke(this, false);
                OnValve?.Invoke(this, true);
                _valveMoveStartet = DateTime.Now;
                return _currentWaterState;
            }
            return _currentWaterState;
        }

        return _currentWaterState;
    }

    public void SwitchWaterOff()
    {
        _currentWaterState = WaterState.SWITCH_WATER_OFF;
    }
}
