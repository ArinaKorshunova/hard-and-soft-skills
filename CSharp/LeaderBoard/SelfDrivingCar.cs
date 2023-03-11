namespace TDDMicroExercises.LeaderBoard;

public record SelfDrivingCar(string AlgorithmVersion, string Company) : IParticipant
{
    public string GetName()
    {
        return $"Self Driving Car - {Company} ({AlgorithmVersion})";
    }
}