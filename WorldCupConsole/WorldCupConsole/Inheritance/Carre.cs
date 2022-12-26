namespace WorldCupConsole.Inheritance;

class Carre:Forme
{
    public double Cote { get; set; }

    public override double ComputePerimeter()
    {
        var perimetre = Cote * 4;
        return perimetre;
    }
}
