namespace WorldCupConsole;

public class Player
{
    public string lastName;
    public string firstName;
    public string age;
    public string position;

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
    public string Age
    {
        get { return this.age; }
        set { this.age = value; }
    }
    public string Position
    {
        get { return this.position; }
        set { this.position = value; }
    }
}
