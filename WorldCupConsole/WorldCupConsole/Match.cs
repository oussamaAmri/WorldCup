namespace WorldCupConsole;

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
        get { return this.teamA; }
        set { this.teamA = value; }
    }

    public Team TeamB
    {
        get { return this.teamB; }
        set { this.teamB = value; }
    }

    public int TeamAscore
    {
        get { return this.teamAscore; }
        set { this.teamAscore = value; }
    }

    public int TeamBscore
    {
        get { return this.teamBscore; }
        set { this.teamBscore = value; }
    }

    public MatchTypes MatchTypes
    {
        get { return this.matchTypes; }
        set { this.matchTypes = value; }
    }

    public Match(Team teamA, Team teamB, int teamAscore,int teamBscore, MatchTypes matchTypes) 
    {
        this.teamA=teamA;
        this.teamB=teamB;
        this.teamAscore=teamAscore;
        this.teamBscore=teamBscore;
        this.matchTypes=matchTypes;
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
        if(teamAscore == teamBscore)
        {
            return null;
        }
        else
        {
            if (teamAscore < teamBscore)
            {
                return teamB;
            }
            else return teamA;
        }
    }

}
