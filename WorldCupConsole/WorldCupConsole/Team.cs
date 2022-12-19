namespace WorldCupConsole;

public class Team
{
    private List<Player> listPlayers = new List<Player>();
    private string name;
    private bool isHost;

    public List<Player> ListPlayers
    {
        get { return this.listPlayers; }
        set { this.listPlayers = value; }
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
    
    public bool IsHost
    {
        get { return this.isHost; }
        set { this.isHost = value; }
    }

    public Team(List<Player> listPlayers,string name,bool isHost)
    {
        this.listPlayers = listPlayers;
        this.name = name;
        this.isHost = isHost;
    }
}
