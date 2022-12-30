using WorldCupConsole.WorldCupExercice;

namespace WorldCupConsole.EmployeeExercice;

public abstract class Employe
{
    public string matricule;
    public string nom;
    public string prenom;
    public DateTime date;

    public string Matricule
    { get { return matricule; } set { matricule = value; } }
    public string Nom
    { get { return nom; } set { nom = value; } }
    public string Prenom
    { get { return prenom; } set { prenom = value; } }
    public DateTime Date
    { get { return date; } set { date = value; } }

    public Employe(string matricule, string nom, string prenom,DateTime date)
    {
        this.matricule = matricule;
        this.nom = nom;
        this.prenom= prenom;
        this.date = date;
    }

    public string ToString()
    {
        return "Employé" + prenom + "," + nom + "," + matricule + ":";
    }
    public abstract int GetSalaire();
}
