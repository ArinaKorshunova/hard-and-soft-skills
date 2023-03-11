namespace TDDMicroExercises.TirePressureMonitoringSystem;

public class Alarm
{
    private const double LowPressureThreshold = 17;
    private const double HighPressureThreshold = 21;

    public bool AlarmOn { get; private set; }

    public void Check()
    {
        var psiPressureValue = Sensor.PopNextPressurePsiValue();
        AlarmOn = psiPressureValue is < LowPressureThreshold or > HighPressureThreshold;
    }
}