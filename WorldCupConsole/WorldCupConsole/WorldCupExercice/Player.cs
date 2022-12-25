namespace WorldCupConsole.WorldCupExercice;

public class Player
{
    public string lastName;
    public string firstName;
    public int age;
    public Position position;

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    public Position Position
    {
        get { return position; }
        set { position = value; }
    }

    public Player(string lastName, string firstName, int age, Position position)
    {
        this.lastName = lastName;
        this.firstName = firstName;
        this.age = age;
        this.position = position;
    }

    public string Tostring()
    {
        return "[" + lastName + "]" + " " + "[" + firstName + "]" + " " + "[" + age + "] ans" + " " + "[" + Position + "]";
    }
}
