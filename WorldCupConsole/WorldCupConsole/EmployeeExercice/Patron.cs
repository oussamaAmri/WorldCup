namespace WorldCupConsole.EmployeeExercice;

public class Patron : Employe
{
    public const int cA = 50000;
    public int pourcentage;

    public Patron(string matricule, string nom, string prenom, DateTime date,int pourcentage) : base(matricule, nom, prenom, date)
    {
        this.pourcentage = pourcentage;
    }
    public override int GetSalaire()
    {
        int salaire = cA * pourcentage / 100;
        return salaire;
    }
}
