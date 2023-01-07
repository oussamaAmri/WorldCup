namespace WorldCupConsole.ParkingExercice
{
    public static class Util
    {
        // Retourne Result.Ok = true si la place est disponible
        // Sinon retourne Result avec la liste des places disponibles
        public static Result PrendreUnePlace(Column column, int etage)
        {
            var parking = FakeData.GetParking();

            throw new NotImplementedException();
        }
    }

    public class Result
    {
        public bool Ok { get; set; }
        public List<Place> FreePlaces { get; set; }
    }
}
