using System.Collections.Generic;
using System.Linq;

namespace TDDMicroExercises.LeaderBoard;

public class Leaderboard
{
    private readonly List<Race> _races = new();

    public Leaderboard(params Race[] races)
    {
        _races.AddRange(races);
    }

    public Dictionary<string, int> ParticipantsResults()
    {
        return _races.SelectMany(x => x.GetParticipantResults())
            .GroupBy(x => x.Key)
            .ToDictionary(e => e.Key, e => e.Sum(x => x.Value));
    }

    public List<string> ParticipantsRankings()
    {
        return ParticipantsResults().OrderByDescending(x => x.Value)
            .GroupBy(x => x.Value).SelectMany(x => x.OrderBy(s => s.Key))
            .Select(x => x.Key).ToList();
    }
}