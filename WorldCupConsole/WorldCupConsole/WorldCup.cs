using System.Text.RegularExpressions;

namespace WorldCupConsole;

public class WorldCup
{
    private string year;
    private string place;
    private List<Group> listOf8Groups = new List<Group>();
    private List<Match> listOf16Matchs = new List<Match>();

    public string Year
    {
        get { return this.year; }
        set { this.year = value; }
    }

    public string Place
    {
        get { return this.place; }
        set { this.place = value; }
    }

    public List<Group> ListOf8Groups
    {
        get { return this.listOf8Groups; }
        set { this.listOf8Groups = value; }
    }
    public List<Match> ListOf16Matchs
    {
        get { return this.listOf16Matchs; }
        set { this.listOf16Matchs = value; }
    }

    public WorldCup(string year, string place, List<Group> listOf8Groups, List<Match> listOf16Matchs)
    {
        this.year = year;
        this.place = place;
        this.listOf8Groups = listOf8Groups;
        this.listOf16Matchs = listOf16Matchs;
    }
    public List<Match> GetRoundOf16()
    {
        var list16 = new List<Team>();
        var listOf16Match = new List<Match>();
        foreach (var listOf16 in listOf16Matchs)
        {
            if (listOf16.MatchTypes == MatchTypes.RoundOf16)
            {
                listOf16Match.Add(listOf16);
            }
        }
        return listOf16Match;
    }
}
