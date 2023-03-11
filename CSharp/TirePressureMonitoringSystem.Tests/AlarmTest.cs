using Xunit;

namespace TDDMicroExercises.TirePressureMonitoringSystem.Tests
{
    public class AlarmTest
    {
        [Fact]
        public void AlarmShouldBeOff()
        {
            Alarm alarm = new Alarm();
            Assert.False(alarm.AlarmOn);
        }
    }
}