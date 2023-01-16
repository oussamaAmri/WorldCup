namespace WorldCupConsole.BouleExercice;

public class Util 
{
    // Retourne true si 3 boules rouges d'affilés
    public bool IsWin()
    {
        var boules = FakeData.GetBoules_1();
        int i = 0;
        bool trouver = false;
        while(i<boules.Count-2)
        {

                if (boules[i].Color == Color.Red && boules[i + 1].Color == Color.Red && boules[i+2].Color == Color.Red)
                {
                    trouver = true;
                    return trouver;
                }
            i++;
        }
        return trouver;
    }
}
