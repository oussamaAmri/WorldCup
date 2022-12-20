// See https://aka.ms/new-console-template for more information
using WorldCupConsole;

public class Program
{
    private static void Main(string[] args)
    {
        Player player = new Player("Mbappé", "Kylian", 24, position: Position.Forward);
        Player player1 = new Player("Antoine ", "Griezmann", 31, position: Position.Forward);

        Player player2 = new Player("Boufal", "Sofiane", 29, position: Position.Middle);
        Player player3 = new Player("Ziyech ", "Hakim", 29, position: Position.Middle);

        List<Player> listPlayersA = new List<Player>();
        List<Player> listPlayersB = new List<Player>();

        List<Match> listEquipes = new List<Match>();

        listPlayersA.Add(player);
        listPlayersA.Add(player1);

        listPlayersB.Add(player2);
        listPlayersB.Add(player3);

        Team TeamA = new Team(listPlayersA, "France", false);
        Team TeamB = new Team(listPlayersB, "Maroc", true);

        Match match = new Match(TeamA, TeamB, 2, 1, matchTypes: MatchTypes.SemiFinals);
        listEquipes.Add(match);
        Group group = new Group(listEquipes, groupe: Groupe.GroupeA);

        //Console.WriteLine(match.ToStringMatch());
        //Console.WriteLine(match.GetWinner());
        
        var result = group.GetTeams();
        foreach(var r in result)
        {
            Console.WriteLine(r.Name);
        }

        var resultMatch = group.GetAllMatchs(TeamA);
        foreach(var r in resultMatch)
        {
            Console.WriteLine(r.ToStringMatch());
        }

        Console.WriteLine(group.Groupe);
    }
}
//Console.WriteLine(Match.GetMatchDuration());