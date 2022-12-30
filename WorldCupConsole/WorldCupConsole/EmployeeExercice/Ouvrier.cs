namespace WorldCupConsole.EmployeeExercice;

public class Ouvrier:Employe
{
    public DateTime DateE;
    public const int smic= 1200;

    public Ouvrier(string matricule, string nom, string prenom, DateTime date,DateTime DateE):base(matricule,nom,prenom,date)
    {
        this.DateE = DateE;
    }
    public override int GetSalaire()
    {
        int datediff = DateTime.Today.Year - DateE.Year;
        int salaire = smic + datediff * 100;
        return salaire; 
    }
}
