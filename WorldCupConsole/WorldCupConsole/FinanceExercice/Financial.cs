namespace WorldCupConsole.FinanceExercice;

public static class Financial
{
    // Retourne le point pour une action donnée à une date donnée
    // Si la date n'existe pas, on fait la moyenne entre la valeur à la date précédente et la valeur à la date suivante
    // Si l'action est inconnue ou bien qu'il n'y a pas des dates pour faire une approximation, on retourne null
    public static Point GetPointByDate(string actionName, DateTime dateTime)
    {
        var allActions = FakeData.GetActions();

        throw new NotImplementedException();
    }

    // Retourne une liste de points entre 2 dates pour une action donnée
    // S'il manque une date, on fait la moyenne entre la valeur à la date précédente et la valeur à la date suivante
    // Dans le cas où il manque plusieurs dates d'affilées, on ne calcule qu'une seule fois la valeur moyenne et on renseigne tout l'interval
    // Si on arrive pas à calculer une approximation, on met la valeur du point à 0
    public static List<Point> GetPoints(string actionName, DateTime startDate, DateTime endDate)
    {
        var allActions = FakeData.GetActions();

        throw new NotImplementedException();
    }
}
