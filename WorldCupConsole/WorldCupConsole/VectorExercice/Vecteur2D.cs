using System.Data.SqlTypes;
using System.IO;
using WorldCupConsole.WorldCupExercice;

namespace WorldCupConsole.VectorExercice;

public class Vecteur2D
{
    public int x;
    public int y;

    public int X
    {
        get { return X; }
        set { X = value; }
    }
    public int Y
    {
        get { return Y; }
        set { Y = value; }
    }
    public Vecteur2D(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public virtual string ToStringV()
    {
        return "X:" + x + "-" + "Y:" + y;
    }

    public bool Equals(Vecteur2D vecteur)
    {
        if (x == vecteur.x && y == vecteur.y)
            return true;
        else return false;
    }
    public virtual double GetNorme()
    {
        return Math.Sqrt(Math.Pow(x,2) + Math.Pow(y,2));
    }

}
