namespace GardenTest.States;

//public enum WaterState
//{
//    ZISTERNE,
//    MOVE,
//    LEITUNG
//}

public class Water
{
    public const string ZISTERNE = "ZISTERNE";
    public const string MOVE = "MOVE";
    public const string LEITUNG = "LEITUNG";

    public string CurrentState { get; set; } = ZISTERNE;
    public DateTime Started { get; set; }
    public int Duration { get; set; } = 10;

    public string TargetState { get; set; } = ZISTERNE;

    public bool WaterLevelGood { get; set; } = false;

    public bool ActiveRequest { get; set; } = false;

    public void GetWater()
    {
        if (WaterLevelGood)
        {
            SetState(ZISTERNE);
        }
        else
        {
            SetState(LEITUNG);
        }

        ActiveRequest = true;
    }

    public void StopWater()
    {
        SetState(ZISTERNE);

        ActiveRequest = false;
    }

    public void SetState(string state)
    {
        TargetState = state;
        if (TargetState != CurrentState)
        {
            CurrentState = MOVE;
            Started = DateTime.Now;
        }
    }

    public void CheckState()
    {
        if (CurrentState == MOVE)
        {
            if (DateTime.Now.Subtract(Started) > TimeSpan.FromSeconds(Duration))
            {
                CurrentState = TargetState;
                Started = default;
            }
        }

        if (TargetState == ZISTERNE && !WaterLevelGood && ActiveRequest)
        {
            SetState(LEITUNG);
        }
    }
}
