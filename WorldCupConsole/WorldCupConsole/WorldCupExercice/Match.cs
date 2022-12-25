namespace WorldCupConsole.WorldCupExercice;

public class Match
{
    private Team teamA;
    private Team teamB;
    private int teamAscore;
    private int teamBscore;
    private MatchTypes matchTypes;
    private const int Duree = 90;

    public Team TeamA
    {
        get { return teamA; }
        set { teamA = value; }
    }

    public Team TeamB
    {
        get { return teamB; }
        set { teamB = value; }
    }

    public int TeamAscore
    {
        get { return teamAscore; }
        set { teamAscore = value; }
    }

    public int TeamBscore
    {
        get { return teamBscore; }
        set { teamBscore = value; }
    }

    public MatchTypes MatchTypes
    {
        get { return matchTypes; }
        set { matchTypes = value; }
    }

    public Match(Team teamA, Team teamB, int teamAscore, int teamBscore, MatchTypes matchTypes)
    {
        this.teamA = teamA;
        this.teamB = teamB;
        this.teamAscore = teamAscore;
        this.teamBscore = teamBscore;
        this.matchTypes = matchTypes;
    }

    static public int GetMatchDuration()
    {
        return Duree;
    }

    public string ToStringMatch()
    {
        return "[" + teamA.Name + "]" + " " + "[" + teamB.Name + "]" + " " + "[" + teamAscore + "]" + " " + "[" + teamBscore + "]" + " " + "[" + matchTypes + "]";
    }

    public Team GetWinner()
    {
        if (teamAscore == teamBscore)
        {
            return null;
        }
        else
        {
            if (teamAscore < teamBscore)
            {
                return teamB;
            }
            else
            {
                return teamA;
            }
        }
    }

}
