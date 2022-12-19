// See https://aka.ms/new-console-template for more information
using WorldCupConsole;

Player player = new Player("Mbappé", "Kylian",24,position:Position.Forward);
Player player1 = new Player("Antoine ", "Griezmann", 31, position: Position.Forward);

Player player2 = new Player("Boufal", "Sofiane", 29, position: Position.Middle);
Player player3 = new Player("Ziyech ", "Hakim", 29, position: Position.Middle);

List<Player> listPlayersA = new List<Player> ();
List<Player> listPlayersB = new List<Player>();
listPlayersA.Add(player);
listPlayersA.Add(player1);

listPlayersB.Add(player2);
listPlayersB.Add(player3);

Team TeamA = new Team(listPlayersA,"France",true);
Team TeamB = new Team(listPlayersB, "Maroc", false);

Match match = new Match(TeamA, TeamB, 1, 1,matchTypes:MatchTypes.SemiFinals) ;

Console.WriteLine(match.ToStringMatch());
