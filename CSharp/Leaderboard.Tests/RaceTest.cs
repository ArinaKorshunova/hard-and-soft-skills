using Xunit;

namespace TDDMicroExercises.LeaderBoard.Tests
{
    public class RaceTest
    {
        [Fact]
        public void ShouldCalculateDriverPoints()
        {
            Assert.Equal(25, TestData.Race1.GetParticipantPoints(TestData.Driver1));
            Assert.Equal(18, TestData.Race1.GetParticipantPoints(TestData.Driver2));
            Assert.Equal(15, TestData.Race1.GetParticipantPoints(TestData.Driver3));
        }
    }
}