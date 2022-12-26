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

    public Triangle(double Cote1, double Cote2, double Cote3)
    {
        this.Cote1 = Cote1;
        this.Cote2 = Cote2;
        this.Cote3 = Cote3;
    }
}
