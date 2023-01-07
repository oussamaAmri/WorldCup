namespace WorldCupConsole.FinanceExercice
{
    public class Action
    {
        public string Name { get; set; }
        public List<Point> Points { get; set; }
    }

    public class Point
    {
        public DateTime Date { get; set; }
        public double Value { get; set; }
    }
}
