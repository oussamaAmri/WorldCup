namespace WorldCupConsole.Code.Errors;

public class MyImplementation : IMyInterface
{
    public List<bool> ComputeAverage(int value,string name) 
    {
        throw new NotImplementedException();
    }

    public void DoSomething()
    {
        Utils.SetSomeValue(1);

        bool a = Utils.GetSomeValue();

        var myList = new List<int>();
        myList.Add(1);
    }
}
