using System.IO;

namespace WorldCupConsole.WorldCupExercice;

public class Team 
{
    private List<Player> listPlayers = new List<Player>();
    private string name;
    private bool isHost;

    public List<Player> ListPlayers
    {
        get { return listPlayers; }
        set { listPlayers = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public bool IsHost
    {
        get { return isHost; }
        set { isHost = value; }
    }

    public Team(List<Player> listPlayers, string name, bool isHost)
    {
        this.listPlayers = listPlayers;
        this.name = name;
        this.isHost = isHost;
    }

    public string getTeams()
    {
        return "[" + name + "] : " + " " + "[" + listPlayers + "] :" + " " + "[" + IsHost + "]";
    }
}
