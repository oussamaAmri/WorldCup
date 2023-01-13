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
            for (int i = 0; i < parking.Places.Length; i++)
            {
                var place = parking.Places[i];
                if (place.Column == column && place.Etage == etage) 
                {
                    if (place.Occupe == true)
                    {
                        result.Ok = false;
                    }
                    else
                    {
                        result.Ok = true;
                    }
                }
            }
            if(result.Ok == false)
            {
                foreach(var p in parking.Places)
                {
                    if(p.Occupe == false)
                    {
                        result.FreePlaces.Add(p);
                    }
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
