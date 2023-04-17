using static System.Windows.Forms.AxHost;

namespace GardenTest.States;

public class Pumpe
{
    public const string ON = "ON";
    public const string OFF = "OFF";

    public string CurrentState { get; set; } = OFF;

    public void SetState(string state)
    {
        CurrentState = state;
    }

    public void CheckState()
    {
    }
}
