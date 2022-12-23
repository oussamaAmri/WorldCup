// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Tracing;
using System.Text.RegularExpressions;
using WorldCupConsole;
using Group = WorldCupConsole.Group;
using Match = WorldCupConsole.Match;

public class Program
{
    private static void Main(string[] args)
    {
        // Joueurs
        Player player = new Player("Mbappé", "Kylian", 24, position: Position.Forward);
        Player player1 = new Player("Antoine ", "Griezmann", 31, position: Position.Forward);

        Player player2 = new Player("Boufal", "Sofiane", 29, position: Position.Middle);
        Player player3 = new Player("Ziyech ", "Hakim", 29, position: Position.Middle);

        // Liste de joueurs par équipe
        List<Player> paysBasPlayers = new List<Player>();
        List<Player> senegalPlayers = new List<Player>();
        List<Player> equateurPlayers = new List<Player>();
        List<Player> qatarPlayers = new List<Player>();

        List<Player> angleterrePlayers = new List<Player>();
        List<Player> usaPlayers = new List<Player>();
        List<Player> iranPlayers = new List<Player>();
        List<Player> paysDeGallesPlayers = new List<Player>();

        List<Player> argentinePlayers = new List<Player>();
        List<Player> polognePlayers = new List<Player>();
        List<Player> mexiquePlayers = new List<Player>();
        List<Player> arabieSaouditePlayers = new List<Player>();

        List<Player> francePlayers = new List<Player>();
        List<Player> australiePlayers = new List<Player>();
        List<Player> tunisiePlayers = new List<Player>();
        List<Player> danemarkPlayers = new List<Player>();

        List<Player> japonPlayers = new List<Player>();
        List<Player> espagnePlayers = new List<Player>();
        List<Player> allemagnePlayers = new List<Player>();
        List<Player> costaRicaPlayers = new List<Player>();

        List<Player> marocPlayers = new List<Player>();
        List<Player> croatiePlayers = new List<Player>();
        List<Player> belgiquePlayers = new List<Player>();
        List<Player> canadaPlayers = new List<Player>();

        List<Player> bresilPlayers = new List<Player>();
        List<Player> suissePlayers = new List<Player>();
        List<Player> camerounPlayers = new List<Player>();
        List<Player> serbiePlayers = new List<Player>();

        List<Player> portugalPlayers = new List<Player>();
        List<Player> coreeDuSudPlayers = new List<Player>();
        List<Player> uruguayPlayers = new List<Player>();
        List<Player> ghanaPlayers = new List<Player>();

        francePlayers.Add(player);
        francePlayers.Add(player1);

        marocPlayers.Add(player2);
        marocPlayers.Add(player3);

        // Equipes
        Team paysBas = new Team(paysBasPlayers, "Pays-Bas", false);
        Team senegal = new Team(senegalPlayers, "Sénégal", false);
        Team equateur = new Team(equateurPlayers, "Equateur", false);
        Team qatar = new Team(qatarPlayers, "Qatar", true);

        Team angleterre = new Team(angleterrePlayers, "Angleterre", false);
        Team usa = new Team(usaPlayers, "USA", false);
        Team iran = new Team(iranPlayers, "Iran", false);
        Team paysDeGalles = new Team(paysDeGallesPlayers, "Pays de Galles", false);

        Team argentine = new Team(argentinePlayers, "Argentine", false);
        Team pologne = new Team(polognePlayers, "Pologne", false);
        Team mexique = new Team(mexiquePlayers, "Mexique", false);
        Team arabieSaoudite = new Team(arabieSaouditePlayers, "Arabie Saoudite", false);

        Team france = new Team(francePlayers, "France", false);
        Team australie = new Team(australiePlayers, "Australie", false);
        Team tunisie = new Team(tunisiePlayers, "Tunisie", false);
        Team danemark = new Team(danemarkPlayers, "Danemark", false);

        Team japon = new Team(japonPlayers, "Japon", false);
        Team espagne = new Team(espagnePlayers, "Espagne", false);
        Team allemagne = new Team(allemagnePlayers, "Allemagne", false);
        Team costaRica = new Team(costaRicaPlayers, "Costa Rica", false);

        Team maroc = new Team(marocPlayers, "Maroc", false);
        Team croatie = new Team(croatiePlayers, "Croatie", false);
        Team belgique = new Team(belgiquePlayers, "Belgique", false);
        Team canada = new Team(canadaPlayers, "Canada", false);

        Team bresil = new Team(bresilPlayers, "Brésil", false);
        Team suisse = new Team(suissePlayers, "Suisse", false);
        Team cameroun = new Team(camerounPlayers, "Cameroun", false);
        Team serbie = new Team(serbiePlayers, "Serbie", false);

        Team portugal = new Team(portugalPlayers, "Portugal", false);
        Team coreeDuSud = new Team(coreeDuSudPlayers, "Corée du Sud", false);
        Team uruguay = new Team(uruguayPlayers, "Uruguay", false);
        Team ghana = new Team(ghanaPlayers, "Ghana", false);

        // Matchs
        Match matchA1 = new Match(qatar, equateur, 0, 2, MatchTypes.GroupeStage);
        Match matchA2 = new Match(senegal, paysBas, 0, 2, MatchTypes.GroupeStage);
        Match matchA3 = new Match(qatar, senegal, 1, 3, MatchTypes.GroupeStage);
        Match matchA4 = new Match(paysBas, equateur, 1, 1, MatchTypes.GroupeStage);
        Match matchA5 = new Match(paysBas, qatar, 2, 0, MatchTypes.GroupeStage);
        Match matchA6 = new Match(equateur, senegal, 1, 2, MatchTypes.GroupeStage);

        Match matchB1 = new Match(angleterre, iran, 6, 2, MatchTypes.GroupeStage);
        Match matchB2 = new Match(usa, paysDeGalles, 1, 1, MatchTypes.GroupeStage);
        Match matchB3 = new Match(paysDeGalles, iran, 0, 2, MatchTypes.GroupeStage);
        Match matchB4 = new Match(angleterre, usa, 0, 0, MatchTypes.GroupeStage);
        Match matchB5 = new Match(paysDeGalles, angleterre, 0, 3, MatchTypes.GroupeStage);
        Match matchB6 = new Match(iran, usa, 0, 1, MatchTypes.GroupeStage);

        Match matchC1 = new Match(argentine, arabieSaoudite, 1, 2, MatchTypes.GroupeStage);
        Match matchC2 = new Match(mexique, pologne, 0, 0, MatchTypes.GroupeStage);
        Match matchC3 = new Match(pologne, arabieSaoudite, 2, 0, MatchTypes.GroupeStage);
        Match matchC4 = new Match(argentine, mexique, 2, 0, MatchTypes.GroupeStage);
        Match matchC5 = new Match(pologne, argentine, 0, 2, MatchTypes.GroupeStage);
        Match matchC6 = new Match(arabieSaoudite, mexique, 1, 2, MatchTypes.GroupeStage);

        Match matchD1 = new Match(danemark, tunisie, 0, 0, MatchTypes.GroupeStage);
        Match matchD2 = new Match(france, australie, 4, 1, MatchTypes.GroupeStage);
        Match matchD3 = new Match(tunisie, australie, 0, 1, MatchTypes.GroupeStage);
        Match matchD4 = new Match(france, danemark, 2, 1, MatchTypes.GroupeStage);
        Match matchD5 = new Match(australie, danemark, 1, 0, MatchTypes.GroupeStage);
        Match matchD6 = new Match(tunisie, france, 1, 0, MatchTypes.GroupeStage);

        Match matchE1 = new Match(allemagne, japon, 1, 2, MatchTypes.GroupeStage);
        Match matchE2 = new Match(espagne, costaRica, 7, 0, MatchTypes.GroupeStage);
        Match matchE3 = new Match(japon, costaRica, 0, 1, MatchTypes.GroupeStage);
        Match matchE4 = new Match(espagne, allemagne, 1, 1, MatchTypes.GroupeStage);
        Match matchE5 = new Match(japon, espagne, 2, 1, MatchTypes.GroupeStage);
        Match matchE6 = new Match(costaRica, allemagne, 2, 4, MatchTypes.GroupeStage);

        Match matchF1 = new Match(maroc, croatie, 0, 0, MatchTypes.GroupeStage);
        Match matchF2 = new Match(belgique, canada, 1, 0, MatchTypes.GroupeStage);
        Match matchF3 = new Match(belgique, maroc, 0, 2, MatchTypes.GroupeStage);
        Match matchF4 = new Match(croatie, canada, 4, 1, MatchTypes.GroupeStage);
        Match matchF5 = new Match(croatie, belgique, 0, 0, MatchTypes.GroupeStage);
        Match matchF6 = new Match(canada, maroc, 1, 2, MatchTypes.GroupeStage);

        Match matchG1 = new Match(suisse, cameroun, 1, 0, MatchTypes.GroupeStage);
        Match matchG2 = new Match(bresil, serbie, 2, 0, MatchTypes.GroupeStage);
        Match matchG3 = new Match(cameroun, serbie, 3, 3, MatchTypes.GroupeStage);
        Match matchG4 = new Match(bresil, suisse, 1, 0, MatchTypes.GroupeStage);
        Match matchG5 = new Match(serbie, suisse, 2, 3, MatchTypes.GroupeStage);
        Match matchG6 = new Match(cameroun, bresil, 1, 0, MatchTypes.GroupeStage);

        Match matchH1 = new Match(uruguay, coreeDuSud, 0, 0, MatchTypes.GroupeStage);
        Match matchH2 = new Match(portugal, ghana, 3, 2, MatchTypes.GroupeStage);
        Match matchH3 = new Match(coreeDuSud, ghana, 2, 3, MatchTypes.GroupeStage);
        Match matchH4 = new Match(portugal, uruguay, 2, 0, MatchTypes.GroupeStage);
        Match matchH5 = new Match(ghana, uruguay, 0, 2, MatchTypes.GroupeStage);
        Match matchH6 = new Match(coreeDuSud, portugal, 2, 1, MatchTypes.GroupeStage);

        List<Match> groupAMatchs = new List<Match>();
        groupAMatchs.Add(matchA1);
        groupAMatchs.Add(matchA2);
        groupAMatchs.Add(matchA3);
        groupAMatchs.Add(matchA4);
        groupAMatchs.Add(matchA5);
        groupAMatchs.Add(matchA6);
        
        List<Match> groupBMatchs = new List<Match>();
        groupBMatchs.Add(matchB1);
        groupBMatchs.Add(matchB2);
        groupBMatchs.Add(matchB3);
        groupBMatchs.Add(matchB4);
        groupBMatchs.Add(matchB5);
        groupBMatchs.Add(matchB6);

        List<Match> groupCMatchs = new List<Match>();
        groupCMatchs.Add(matchC1);
        groupCMatchs.Add(matchC2);
        groupCMatchs.Add(matchC3);
        groupCMatchs.Add(matchC4);
        groupCMatchs.Add(matchC5);
        groupCMatchs.Add(matchC6);

        List<Match> groupDMatchs = new List<Match>();
        groupDMatchs.Add(matchD1);
        groupDMatchs.Add(matchD2);
        groupDMatchs.Add(matchD3);
        groupDMatchs.Add(matchD4);
        groupDMatchs.Add(matchD5);
        groupDMatchs.Add(matchD6);

        List<Match> groupEMatchs = new List<Match>();
        groupEMatchs.Add(matchE1);
        groupEMatchs.Add(matchE2);
        groupEMatchs.Add(matchE3);
        groupEMatchs.Add(matchE4);
        groupEMatchs.Add(matchE5);
        groupEMatchs.Add(matchE6);

        List<Match> groupFMatchs = new List<Match>();
        groupFMatchs.Add(matchF1);
        groupFMatchs.Add(matchF2);
        groupFMatchs.Add(matchF3);
        groupFMatchs.Add(matchF4);
        groupFMatchs.Add(matchF5);
        groupFMatchs.Add(matchF6);

        List<Match> groupGMatchs = new List<Match>();
        groupGMatchs.Add(matchG1);
        groupGMatchs.Add(matchG2);
        groupGMatchs.Add(matchG3);
        groupGMatchs.Add(matchG4);
        groupGMatchs.Add(matchG5);
        groupGMatchs.Add(matchG6);

        List<Match> groupHMatchs = new List<Match>();
        groupHMatchs.Add(matchH1);
        groupHMatchs.Add(matchH2);
        groupHMatchs.Add(matchH3);
        groupHMatchs.Add(matchH4);
        groupHMatchs.Add(matchH5);
        groupHMatchs.Add(matchH6);

        // Groupes
        Group groupA = new Group(groupAMatchs, Groupe.GroupeA);
        Group groupB = new Group(groupBMatchs, Groupe.GroupeB);
        Group groupC = new Group(groupCMatchs, Groupe.GroupeC);
        Group groupD = new Group(groupDMatchs, Groupe.GroupeD);
        Group groupE = new Group(groupEMatchs, Groupe.GroupeE);
        Group groupF = new Group(groupFMatchs, Groupe.GroupeF);
        Group groupG = new Group(groupGMatchs, Groupe.GroupeG);
        Group groupH = new Group(groupHMatchs, Groupe.GroupeH);

        //WorldCup
/*        var resultGagnantA = groupA.GetQualifiedTeams();
        var resultGagnantB = groupB.GetQualifiedTeams();
        var resultGagnantC = groupC.GetQualifiedTeams();
        var resultGagnantD = groupD.GetQualifiedTeams();
        var resultGagnantE = groupE.GetQualifiedTeams();
        var resultGagnantF = groupF.GetQualifiedTeams();
        var resultGagnantG = groupG.GetQualifiedTeams();
        var resultGagnantH = groupH.GetQualifiedTeams();*/
        List<Match> listOf16Matchs = new List<Match>();
        List<Group> listOf8Groups = new List<Group>();
        listOf8Groups.Add(groupA);
        listOf8Groups.Add(groupB);
        listOf8Groups.Add(groupC);
        listOf8Groups.Add(groupD);
        listOf8Groups.Add(groupE);
        listOf8Groups.Add(groupF);
        listOf8Groups.Add(groupG);
        listOf8Groups.Add(groupH);

        Match matchI1 = new Match(belgique, maroc, 0, 2, MatchTypes.RoundOf16);
        Match matchI2 = new Match(croatie, canada, 4, 1, MatchTypes.RoundOf16);
        Match matchI3 = new Match(croatie, belgique, 0, 0, MatchTypes.RoundOf16);
        Match matchI4 = new Match(canada, maroc, 1, 2, MatchTypes.RoundOf16);

        Match matchJ1 = new Match(suisse, cameroun, 1, 0, MatchTypes.RoundOf16);
        Match matchJ2 = new Match(bresil, serbie, 2, 0, MatchTypes.RoundOf16);
        Match matchJ3 = new Match(cameroun, serbie, 3, 3, MatchTypes.RoundOf16);
        Match matchJ4 = new Match(bresil, suisse, 1, 0, MatchTypes.RoundOf16);
        Match matchJ5 = new Match(serbie, suisse, 2, 3, MatchTypes.RoundOf16);
        Match matchJ6 = new Match(cameroun, bresil, 1, 0, MatchTypes.RoundOf16);

        Match matchJ7 = new Match(uruguay, coreeDuSud, 0, 0, MatchTypes.RoundOf16);
        Match matchJ8 = new Match(portugal, ghana, 3, 2, MatchTypes.RoundOf16);
        Match matchJ9 = new Match(coreeDuSud, ghana, 2, 3, MatchTypes.RoundOf16);
        Match matchJ10 = new Match(portugal, uruguay, 2, 0, MatchTypes.RoundOf16);
        Match matchJ11 = new Match(ghana, uruguay, 0, 2, MatchTypes.RoundOf16);
        Match matchJ12 = new Match(coreeDuSud, portugal, 2, 1, MatchTypes.RoundOf16);

        listOf16Matchs.Add(matchI1);
        listOf16Matchs.Add(matchI2);
        listOf16Matchs.Add(matchI3);
        listOf16Matchs.Add(matchI4);
        listOf16Matchs.Add(matchJ1);
        listOf16Matchs.Add(matchJ2);
        listOf16Matchs.Add(matchJ3);
        listOf16Matchs.Add(matchJ4);
        listOf16Matchs.Add(matchJ5);
        listOf16Matchs.Add(matchJ6);
        listOf16Matchs.Add(matchJ7);
        listOf16Matchs.Add(matchJ8);
        listOf16Matchs.Add(matchJ9);
        listOf16Matchs.Add(matchJ10);
        listOf16Matchs.Add(matchJ11);
        listOf16Matchs.Add(matchJ12);


        Match matchJ13 = new Match(serbie, suisse, 2, 3, MatchTypes.QuaterFinals);
        Match matchJ14 = new Match(cameroun, bresil, 1, 0, MatchTypes.QuaterFinals);

        Match matchJ15 = new Match(uruguay, coreeDuSud, 0, 0, MatchTypes.QuaterFinals);
        Match matchJ16 = new Match(portugal, ghana, 3, 2, MatchTypes.QuaterFinals);
        Match matchJ17 = new Match(coreeDuSud, ghana, 2, 3, MatchTypes.QuaterFinals);
        Match matchJ18 = new Match(portugal, uruguay, 2, 0, MatchTypes.QuaterFinals);
        Match matchJ19 = new Match(ghana, uruguay, 0, 2, MatchTypes.QuaterFinals);
        Match matchJ20 = new Match(coreeDuSud, portugal, 2, 1, MatchTypes.QuaterFinals);

 /*       listOf8Groups.Add(matchJ13);
        listOf8Groups.Add(matchJ14);
        listOf8Groups.Add(matchJ15);
        listOf8Groups.Add(matchJ16);
        listOf8Groups.Add(matchJ17);
        listOf8Groups.Add(matchJ18);
        listOf8Groups.Add(matchJ19);
        listOf8Groups.Add(matchJ20);
 */
        Match matchJ21 = new Match(coreeDuSud, ghana, 2, 3, MatchTypes.SemiFinals);
        Match matchJ22 = new Match(portugal, uruguay, 2, 0, MatchTypes.SemiFinals);
        Match matchJ23 = new Match(ghana, uruguay, 0, 2, MatchTypes.SemiFinals);
        Match matchJ24 = new Match(coreeDuSud, portugal, 2, 1, MatchTypes.Final);
/*
        listOf8Groups.Add(matchJ21);
        listOf8Groups.Add(matchJ22);
        listOf8Groups.Add(matchJ23);
        listOf8Groups.Add(matchJ24);
*/
        WorldCup worldCup = new WorldCup("2022","Qatar", listOf8Groups, listOf16Matchs);
        Team teamA = new Team(coreeDuSudPlayers, "Corée du Sud", false);
        Team teamB = new Team(portugalPlayers, "Portugal", false);

        var resultWorldCup16 = worldCup.GetRoundOf16();
        var resultWorldCup8 = worldCup.GetQuaterFinals();
//        var resultat = worldCup.GetWinnerW(teamA,teamB);
        var resultat = worldCup.GetWinnerW();
        Console.WriteLine(resultat.Name);
        //        var resultSemiFinal = worldCup.GetSemiFinals();
        var resultSemiFinal = worldCup.GetFinal();
        //        Console.WriteLine(resultSemiFinal.ToStringMatch());
//            Console.WriteLine(resultat.Name);
/*                foreach (var r in resultat)
                {
                    Console.WriteLine(r.Name);
                }
 */       
        //Console.WriteLine(worldCup.GetRoundOf16(listOf16Matchs));
        //Console.WriteLine(match.ToStringMatch());
        //Console.WriteLine(match.GetWinner());
        //Console.WriteLine(Match.GetMatchDuration());

        //var result = groupA.GetTeams();

        // Huitième de  finale 

        //GroupeA
        /*        var resultGagnantA = groupA.GetQualifiedTeams(); 
                Console.WriteLine("Equipe " + groupA.Groupe);
                foreach (var r in resultGagnantA)
                {
                    Console.WriteLine(r.Name);
                }
                */

        //GroupB
        /*        var resultGagnantB = groupB.GetQualifiedTeams();
                Console.WriteLine("Equipe " + groupB.Groupe);
                foreach (var r in resultGagnantB)
                {
                    Console.WriteLine(r.Name);
                }
                //GroupC
                var resultGagnantC = groupC.GetQualifiedTeams();
                Console.WriteLine("Equipe " + groupC.Groupe);
                foreach (var r in resultGagnantC)
                {
                    Console.WriteLine(r.Name);
                }

                //GroupD
                var resultGagnantD = groupD.GetQualifiedTeams();
                Console.WriteLine("Equipe " + groupD.Groupe);
                foreach (var r in resultGagnantD)
                {
                    Console.WriteLine(r.Name);
                }
                //GroupE
                var resultGagnantE = groupE.GetQualifiedTeams();
                Console.WriteLine("Equipe " + groupE.Groupe);
                foreach (var r in resultGagnantE)
                {
                    Console.WriteLine(r.Name);
                }
                //GroupF
                var resultGagnantF = groupF.GetQualifiedTeams();
                Console.WriteLine("Equipe " + groupF.Groupe);
                foreach (var r in resultGagnantF)
                {
                    Console.WriteLine(r.Name);
                }
                //GroupG
                var resultGagnantG = groupG.GetQualifiedTeams();
                Console.WriteLine("Equipe " + groupG.Groupe);
                foreach (var r in resultGagnantG)
                {
                    Console.WriteLine(r.Name);
                }
                //GroupH
                var resultGagnantH = groupH.GetQualifiedTeams();
                Console.WriteLine("Equipe " + groupH.Groupe);
                foreach (var r in resultGagnantH)
                {
                    Console.WriteLine(r.Name);
                }

                var resultMatch = groupE.GetAllMatchs(japon);
                Console.WriteLine("Parcours équipe " + japon.Name);
                foreach (var r in resultMatch)
                {
                    Console.WriteLine(r.ToStringMatch());
                }*/
    }
}