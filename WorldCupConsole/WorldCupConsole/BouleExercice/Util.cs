namespace WorldCupConsole.BouleExercice;

public class Util 
{
    // Retourne true si 3 boules rouges d'affilés
    public bool IsWin()
    {
        var boules = FakeData.GetBoules_1();
        for(int i = 0; i<=boules.Count-1;i++)
        {
            if (boules[i].Color == Color.Red && boules[i+1].Color == Color.Red && boules[i+2].Color == Color.Red) 
                return true;
        }
        return false;
    }
}
