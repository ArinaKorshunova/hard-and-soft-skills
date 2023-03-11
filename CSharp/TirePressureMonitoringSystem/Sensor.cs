using System;

namespace TDDMicroExercises.TirePressureMonitoringSystem;

public static class Sensor
{
    private const double Offset = 16;

    public static double PopNextPressurePsiValue()
    {
        return Offset + SamplePressure();
    }

    private static double SamplePressure()
    {
        var random = new Random();
        return 6 * random.NextDouble() * random.NextDouble();
    }
}