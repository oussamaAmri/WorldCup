namespace WorldCupConsole.Inheritance;

class Triangle : Forme
{
    public double Cote1 { get; set;}
    public double Cote2 { get; set; }
    public double Cote3 { get; set; }
    public override double ComputePerimeter()
    {
        var perimetre = (Cote1 + Cote2 + Cote3);
        return perimetre;
    }
}
