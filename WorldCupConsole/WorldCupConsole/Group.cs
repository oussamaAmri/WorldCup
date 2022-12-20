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
        foreach(var m in listOfMatchs)
        {
            listEquipe.Add(m.TeamA);
            listEquipe.Add(m.TeamB);
        }
        var listEquipes = listEquipe.DistinctBy(m => m.Name);
        return listEquipes.ToList();
    }
}

