namespace GardenTest.States;

public class Sprinkling
{
    public const string OFF = "OFF";
    public const string PREPERATION = "PREPERATION";
    public const string MANUELL = "MANUELL";
    public const string WERFER = "WERFER";
    public const string SPRÜHER = "SPRÜHER";
    public const string TROPFER = "TROPFER";

    public string CurrentState { get; set; } = OFF;
    public string TargetState { get; set; } = OFF;

    public DateTime Started { get; set; }
    public int Duration { get; set; } = 10;

    public void SetState(string state)
    {
        TargetState = state;
        if (TargetState != CurrentState)
        {
            CurrentState = PREPERATION;
        } else
        {
            Started = DateTime.Now;
        }
    }

    public void PreperationDone()
    {
        if (CurrentState != TargetState)
        {
            CurrentState = TargetState;
            Started = DateTime.Now;
        }
    }

    public void CheckState()
    {
        if (CurrentState != PREPERATION && CurrentState != MANUELL)
        {
            if (DateTime.Now.Subtract(Started) > TimeSpan.FromSeconds(Duration))
            {
                SetState(OFF);
                Started = default;
            }
        }
    }
}
