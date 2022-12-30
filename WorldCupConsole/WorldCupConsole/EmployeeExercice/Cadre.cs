using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WorldCupConsole.EmployeeExercice;
public class Cadre:Employe
{
    public CadreIndice cadreIndice;


    public Cadre(string matricule, string nom, string prenom, DateTime date, CadreIndice cadreIndice) : base(matricule, nom, prenom, date)
    {
        this.cadreIndice = cadreIndice;
    }
    public override int GetSalaire()
    {
        switch (cadreIndice)
        {
            case CadreIndice.Indice1:
                return 2000;
                break;
            case CadreIndice.Indice2:
                return 2500;
                break;
            case CadreIndice.Indice3:
                return 3000;
                break;
            default:
                return 3500;
        }
    }
}
