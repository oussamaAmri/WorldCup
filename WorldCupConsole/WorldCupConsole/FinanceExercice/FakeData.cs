namespace WorldCupConsole.FinanceExercice;

public static class FakeData
{
    public static List<Action> GetActions()
    {
        return new List<Action>
        {
            new Action
            {
                Name = "BNP PARIBAS",
                Points = new List<Point>
                {
                    new Point
                    {
                        Date = new DateTime(2020, 01, 01),
                        Value = 59.11
                    },
                    new Point
                    {
                        Date = new DateTime(2020, 01, 02),
                        Value = 58.61
                    },
                    new Point
                    {
                        Date = new DateTime(2020, 01, 04),
                        Value = 56.01
                    },
                    new Point
                    {
                        Date = new DateTime(2020, 01, 05),
                        Value = 54.93
                    },
                    new Point
                    {
                        Date = new DateTime(2020, 01, 06),
                        Value = 53.45
                    },
                    new Point
                    {
                        Date = new DateTime(2020, 01, 07),
                        Value = 52.17
                    },
                    new Point
                    {
                        Date = new DateTime(2020, 01, 08),
                        Value = 54.26
                    },
                    new Point
                    {
                        Date = new DateTime(2020, 01, 09),
                        Value = 53.78
                    },
                    new Point
                    {
                        Date = new DateTime(2020, 01, 11),
                        Value = 53.45
                    },
                    new Point
                    {
                        Date = new DateTime(2020, 01, 12),
                        Value = 54.33
                    },
                    new Point
                    {
                        Date = new DateTime(2020, 01, 13),
                        Value = 54.47
                    },
                    new Point
                    {
                        Date = new DateTime(2020, 01, 14),
                        Value = 55.26
                    },
                    new Point
                    {
                        Date = new DateTime(2020, 01, 16),
                        Value = 55.83
                    }
                }   
            },
            new Action
            {
                Name = "BOUYGUES",
                Points = new List<Point>
                {
                    new Point
                    {
                        Date = new DateTime(2020, 01, 01),
                        Value = 29.8
                    },
                    new Point
                    {
                        Date = new DateTime(2020, 01, 02),
                        Value = 29.78
                    },
                    new Point
                    {
                        Date = new DateTime(2020, 01, 03),
                        Value = 29.77
                    },
                    new Point
                    {
                        Date = new DateTime(2020, 01, 04),
                        Value = 29.75
                    },
                    new Point
                    {
                        Date = new DateTime(2020, 01, 05),
                        Value = 29.72
                    },
                    new Point
                    {
                        Date = new DateTime(2020, 01, 08),
                        Value = 29.27
                    },
                    new Point
                    {
                        Date = new DateTime(2020, 01, 09),
                        Value = 28.6
                    },
                    new Point
                    {
                        Date = new DateTime(2020, 01, 10),
                        Value = 28.51
                    },
                    new Point
                    {
                        Date = new DateTime(2020, 01, 11),
                        Value = 28.12
                    },
                    new Point
                    {
                        Date = new DateTime(2020, 01, 13),
                        Value = 27.87
                    },
                    new Point
                    {
                        Date = new DateTime(2020, 01, 14),
                        Value = 27.67
                    },
                    new Point
                    {
                        Date = new DateTime(2020, 01, 16),
                        Value = 27.24
                    }
                }
            }
        };
    }
}
