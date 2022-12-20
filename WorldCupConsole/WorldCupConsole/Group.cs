using System.IO;

namespace WorldCupConsole;

public class Group
{
    private List<Match> listOfMatchs = new List<Match>();
    private Groupe groupe;
    public List<Match> ListOfMatchs
    {
        get { return this.listOfMatchs; }
        set { this.listOfMatchs = value; }
    }

    public Groupe Groupe
    {
        get { return this.groupe; }
        set { this.groupe = value; }
    }
    public Group(List<Match> listOfMatchs, Groupe groupe)
    {
        this.listOfMatchs = listOfMatchs;
        this.groupe = groupe;    
    }
    
    public List<Team> GetTeams() 
    {
        var listEquipe = new List<Team>();
        foreach(var e in listOfMatchs)
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
        foreach(var m in listOfMatchs)
        {
            if((m.TeamA.Name == equipe.Name) || (m.TeamB.Name == equipe.Name))
            {
                listMatch.Add(m);
            }
        }
        return listMatch;
    }
    
}

