namespace WorldCupConsole.ParkingExercice
{
    public static class UtilP
    {
        // Retourne Result.Ok = true si la place est disponible
        // Sinon retourne Result avec la liste des places disponibles
        public static Result PrendreUnePlace(Column column, int etage)
        {
            var parking = FakeData.GetParking();
            var result = new Result
            {
                Ok = true,
                FreePlaces = new List<Place> { }
            };
            for(int i = 0;i<parking.Places.Length;i++)
            {
                var place = parking.Places[i];
                if (place.Occupe == false)
                {
                    result.Ok = true;
                }
                else
                {
                    result.FreePlaces.Add(place);
                }
            }
            return result;
        }
    }

    public class Result
    {
        public bool Ok { get; set; }
        public List<Place> FreePlaces { get; set; }
    }
}
