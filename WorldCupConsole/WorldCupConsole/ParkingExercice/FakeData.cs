    namespace WorldCupConsole.ParkingExercice;

public static class FakeData
{
    public static Parking GetParking()
    {
        return new Parking
        {
            Places = new[]
            {
                new Place
                {
                    Column = Column.A,
                    Etage = 0,
                    Occupe = false
                },
                new Place
                {
                    Column = Column.B,
                    Etage = 0,
                    Occupe = true
                },
                new Place
                {
                    Column = Column.C,
                    Etage = 0,
                    Occupe = false
                },
                new Place
                {
                    Column = Column.D,
                    Etage = 0,
                    Occupe = true
                },
                new Place
                {
                    Column = Column.A,
                    Etage = 1,
                    Occupe = true
                },
                new Place
                {
                    Column = Column.B,
                    Etage = 1,
                    Occupe = false
                },
                new Place
                {
                    Column = Column.C,
                    Etage = 1,
                    Occupe = true
                },
                new Place
                {
                    Column = Column.D,
                    Etage = 1,
                    Occupe = true
                },
                new Place
                {
                    Column = Column.A,
                    Etage = 2,
                    Occupe = true
                },
                new Place
                {
                    Column = Column.B,
                    Etage = 2,
                    Occupe = true
                },
                new Place
                {
                    Column = Column.C,
                    Etage = 2,
                    Occupe = false
                },
                new Place
                {
                    Column = Column.D,
                    Etage = 2,
                    Occupe = true
                },
                new Place
                {
                    Column = Column.A,
                    Etage = 3,
                    Occupe = true
                },
                new Place
                {
                    Column = Column.B,
                    Etage = 3,
                    Occupe = false
                },
                new Place
                {
                    Column = Column.C,
                    Etage = 3,
                    Occupe = false
                },
                new Place
                {
                    Column = Column.D,
                    Etage = 3,
                    Occupe = true
                }
            }
        };
    }
}
