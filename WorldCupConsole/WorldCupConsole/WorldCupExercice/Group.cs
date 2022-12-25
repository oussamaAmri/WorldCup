using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.IO;

namespace WorldCupConsole.WorldCupExercice;

public class Group
{
    private List<Match> listOfMatchs = new List<Match>();
    private Groupe groupe;
    public List<Match> ListOfMatchs
    {
        get { return listOfMatchs; }
        set { listOfMatchs = value; }
    }

    public Groupe Groupe
    {
        get { return groupe; }
        set { groupe = value; }
    }
    public Group(List<Match> listOfMatchs, Groupe groupe)
    {
        this.listOfMatchs = listOfMatchs;
        this.groupe = groupe;
    }

    public List<Team> GetTeams()
    {
        var listEquipe = new List<Team>();
        foreach (var e in listOfMatchs)
        {
            listEquipe.Add(e.TeamA);
            listEquipe.Add(e.TeamB);
        }
        var listEquipes = listEquipe.DistinctBy(e => e.Name);
        return listEquipes.ToList();
    }

    public List<Match> GetAllMatchs(Team equipe)
    {
        var listMatch = new List<Match>();
        foreach (var m in listOfMatchs)
        {
            if (m.TeamA.Name == equipe.Name || m.TeamB.Name == equipe.Name)
            {
                listMatch.Add(m);
            }
        }
        return listMatch;
    }
    public List<Team> GetQualifiedTeams()
    {
        var cpt = 0;
        var getTeams = GetTeams();
        var nbrEquipe = getTeams.Count;
        var listQualifiedTeams = new List<Team>();

        var myDic2 = new Dictionary<string, int> { };

        foreach (var e in getTeams)
        {
            myDic2.Add(e.Name, 0);
        }

        foreach (var match in listOfMatchs)
        {
            Team team = match.GetWinner();
            if (team != null)
            {
                myDic2[team.Name] = myDic2[team.Name] + 3;
            }
            else
            {
                myDic2[match.TeamA.Name] = myDic2[match.TeamA.Name] + 1;
                myDic2[match.TeamB.Name] = myDic2[match.TeamB.Name] + 1;
            }
        }
        var listGagnant = myDic2.OrderByDescending(v => v.Value).Take(2).ToDictionary(k => k.Key, v => v.Value).Keys.ToList();

        foreach (var l in getTeams)
        {
            if (l.Name == listGagnant[0] || l.Name == listGagnant[1])
            {
                listQualifiedTeams.Add(l);
            }
        }
        return listQualifiedTeams;
    }


}

