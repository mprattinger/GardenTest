namespace GardenTest;

public enum Actions
{
    UNKNOWN,
    TROPFER,
    WERFER,
    SRPUEHER,
    MANUELL
}


public partial class Form1 : Form
{
    private System.Windows.Forms.Timer _timer;
    private Actions _currentAction = Actions.UNKNOWN;

    private WaterState _currentWaterState = WaterState.UNKNOWN;
    private WaterSupply _waterSupply = new();

    private DateTime _actionStarted = default;

    public Form1()
    {
        InitializeComponent();
        lblCurrentMode.Text = _currentAction.ToString();
        lblWaterState.Text = _currentWaterState.ToString();

        _waterSupply.WaterLevel(cbWaterLevel.Checked);
        cbWaterLevel.CheckedChanged += CbWaterLevel_CheckedChanged;

        _waterSupply.OnValve += (s, e) =>
        {
            cbValve.Checked = e;
        };
        _waterSupply.OnPump += (s, e) =>
        {
            cbPump.Checked = e;
        };

        _timer = new();
        _timer.Interval = 1000;
        _timer.Tick += _timer_Tick;
        _timer.Start();
    }

    private void _timer_Tick(object? sender, EventArgs e)
    {
        lblCurrentMode.Text = _currentAction.ToString();
        lblWaterState.Text = _waterSupply.CheckWaterSupplyState().ToString();

        if (_currentAction == Actions.UNKNOWN || _currentAction == Actions.MANUELL)
        {
            return;
        }

        if (DateTime.Now.Subtract(_actionStarted) < TimeSpan.FromSeconds(20))
        {
            return;
        }

        _waterSupply.SwitchWaterOff();
        _currentAction = Actions.UNKNOWN;
    }

    private void CbWaterLevel_CheckedChanged(object? sender, EventArgs e)
    {
        _waterSupply.WaterLevel(cbWaterLevel.Checked);
    }


    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnManuell_Click(object sender, EventArgs e)
    {
        if (_currentAction == Actions.MANUELL)
        {
            _currentAction = Actions.UNKNOWN;
            _waterSupply.SwitchWaterOff();
            return;
        }

        _currentAction = Actions.MANUELL;
        _waterSupply.SwitchWaterOn();
    }

    private void btnWerfer_Click(object sender, EventArgs e)
    {
        if(_currentAction == Actions.WERFER)
        {

            _currentAction = Actions.UNKNOWN;
            _waterSupply.SwitchWaterOff();
            _actionStarted = default;
            return;
        }

        if (_currentAction != Actions.UNKNOWN) return;

        _currentAction = Actions.WERFER;
        _waterSupply.SwitchWaterOn();
        _actionStarted = DateTime.Now;
    }

    private void btnSprueher_Click(object sender, EventArgs e)
    {
        if (_currentAction == Actions.SRPUEHER)
        {
            _currentAction = Actions.UNKNOWN;
            _waterSupply.SwitchWaterOff();
            _actionStarted = default;
            return;
        }

        if (_currentAction != Actions.UNKNOWN) return;

        _currentAction = Actions.SRPUEHER;
        _waterSupply.SwitchWaterOn();
        _actionStarted = DateTime.Now;
    }

    private void btnTropfer_Click(object sender, EventArgs e)
    {
        if (_currentAction == Actions.TROPFER)
        {
            _currentAction = Actions.UNKNOWN;
            _waterSupply.SwitchWaterOff();
            _actionStarted = default;
            return;
        }

        if (_currentAction != Actions.UNKNOWN) return;

        _currentAction = Actions.TROPFER;
        _waterSupply.SwitchWaterOn();
        _actionStarted = DateTime.Now;
    }
}