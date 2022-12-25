using Microsoft.VisualBasic;
using System.Diagnostics.Tracing;
using System.Text.RegularExpressions;

namespace WorldCupConsole.WorldCupExercice;

public class WorldCup
{
    private string year;
    private string place;
    private List<Group> listOf8Groups = new List<Group>();
    private List<Match> listOf16Matchs = new List<Match>();
    private const int yearOfWorldCup = 1930;

    public string Year
    {
        get { return year; }
        set { year = value; }
    }

    public string Place
    {
        get { return place; }
        set { place = value; }
    }

    public List<Group> ListOf8Groups
    {
        get { return listOf8Groups; }
        set { listOf8Groups = value; }
    }
    public List<Match> ListOf16Matchs
    {
        get { return listOf16Matchs; }
        set { listOf16Matchs = value; }
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

    public List<Match> GetQuaterFinals()
    {
        var listOf16Match = new List<Match>();
        foreach (var listOf8 in listOf16Match)
        {
            if (listOf8.MatchTypes == MatchTypes.QuaterFinals)
            {
                listOf16Match.Add(listOf8);
            }
        }
        return listOf16Match;
    }

    public List<Match> GetSemiFinals()
    {
        var listDM = new List<Match>();
        foreach (var listOfDM in listOf16Matchs)
        {
            if (listOfDM.MatchTypes == MatchTypes.SemiFinals)
            {
                listDM.Add(listOfDM);
            }
        }
        return listDM;
    }

    public Match GetThirdPlacePlayOff()
    {
        Match place = null;
        foreach (var p in listOf16Matchs)
        {
            if (p.MatchTypes == MatchTypes.ThirdPlacePlayOff)
            {
                place = p;
            }
        }
        return place;
    }

    public Match GetFinal()
    {
        Match place = null;
        foreach (var p in listOf16Matchs)
        {
            if (p.MatchTypes == MatchTypes.Final)
            {
                place = p;
            }
        }
        return place;
    }

    /*    public List<Team> GetWinnerW(Team teamA, Team teamB)
        {
            var getFinal = GetFinal();
            List<Match> listWinner = new List<Match>();
            List<Team> listwin = new List<Team>();
            listWinner.Add(getFinal);
            foreach (var match in listWinner)
            {
                if (match.TeamA.Name == teamA.Name && match.TeamB.Name == teamB.Name)
                {
                    Team team = match.GetWinner();
                    listwin.Add(team);
                }
            }
            return listwin;
            }
    */
    public Team GetWinnerW()
    {
        var final = GetFinal();

        return final.GetWinner();
    }

    public List<Match> GetJourney(Team equipe)
    {
        var listMatch = new List<Match>();
        foreach (var match in listOf16Matchs)
        {
            if (match.TeamA.Name == equipe.Name || match.TeamB.Name == equipe.Name)
            {
                listMatch.Add(match);
            }
        }
        foreach (var g in listOf8Groups)
        {
            foreach (var i in g.ListOfMatchs)
            {
                if (i.TeamA.Name == equipe.Name || i.TeamB.Name == equipe.Name)
                {
                    listMatch.Add(i);
                }
            }
        }
        return listMatch;
    }

    public static int GetWorldCupFirstYear()
    {
        return yearOfWorldCup;
    }
}
