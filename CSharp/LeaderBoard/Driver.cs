namespace TDDMicroExercises.LeaderBoard;

public record Driver(string Name, string Country) : IParticipant
{
    public string GetName()
    {
        return Name;
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode() * 31 + Country.GetHashCode();
    }
}