namespace WorldCupConsole;

public class Player
{
    public string lastName;
    public string firstName;
    public int age;
    public Position position;

    public string LastName
    {
        get { return this.lastName; }
        set { this.lastName = value; }
    }

    public string FirstName
    {
        get { return this.firstName; }
        set { this.firstName = value; }
    }
    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }
    public Position Position
    {
        get { return this.position; }
        set { this.position = value; }
    }

    public Player(string lastName,string firstName,int age,Position position )
    {
        this.lastName = lastName;
        this.firstName = firstName;
        this.age = age;
        this.position = position;
    }

    public string Tostring()
    {
        return "[" + this.lastName + "]" + " " + "[" + firstName +"]" + " " + "[" + age + "] ans" + " " + "[" + Position.Forward + "]";
    }
}
