namespace WorldCupConsole.Code.Errors;

internal class MyImplementation : IMyInterface
{
    internal List<int> ComputeAverage(int name)
    {
        throw new NotImplementedException();
    }

    internal void DoSomething()
    {
        Utils.SetSomeValue("1");

        int a = Utils.GetSomeValue();

        var myList = new List<int>();
        myList.Add("element");
    }
}
