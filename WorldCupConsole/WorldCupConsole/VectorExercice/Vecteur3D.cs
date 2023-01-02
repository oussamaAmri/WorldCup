using WorldCupConsole.EmployeeExercice;

namespace WorldCupConsole.VectorExercice;

public class Vecteur3D : Vecteur2D
{
    public int z;
    public int Z
    {
        get { return z; }
        set { z = value; }
    }
    public Vecteur3D(int x , int y, int z) : base(x,y)
    {
        this.z = z;
    }

    public override string ToStringV()
    {
        return "X:" + x + "-" + "Y:" + y + "Z:" + z;
    }
    public bool Equals(Vecteur3D vecteur)
    {
        if (x == vecteur.x && y == vecteur.y && z == vecteur.z)
            return true;
        else return false;
    }
    public override double GetNorme()
    {
        return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z,2));
    }
}
