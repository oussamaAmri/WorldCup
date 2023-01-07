namespace WorldCupConsole.ParkingExercice
{
    public class Parking
    {
        public Place[] Places { get; set; }
    }

    public class Place
    {
        public Column Column { get; set; }
        public int Etage { get; set; }
        public bool Occupe { get; set; }
    }

    public enum Column
    {
        A,
        B,
        C,
        D
   }
}
