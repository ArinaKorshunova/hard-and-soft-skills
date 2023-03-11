using System.Collections.Generic;
using System.Linq;

namespace TDDMicroExercises.LeaderBoard;

public class Race
{
    private static readonly int[] Points = {25, 18, 15};
    private readonly string _name;

    public Race(string name, params IParticipant[] participants)
    {
        _name = name;
        Participants.AddRange(participants);
    }

    private List<IParticipant> Participants { get; } = new();

    private int Position(IParticipant driver)
    {
        return Participants.FindIndex(d => Equals(d, driver));
    }

    public int GetParticipantPoints(IParticipant participant)
    {
        return Points[Position(participant)];
    }

    public Dictionary<string, int> GetParticipantResults()
    {
        return Participants.ToDictionary(x => x.GetName(), GetParticipantPoints);
    }

    public override string ToString()
    {
        return _name;
    }
}