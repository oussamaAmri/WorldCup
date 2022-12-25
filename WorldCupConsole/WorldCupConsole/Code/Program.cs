using WorldCupConsole.Code.Errors;

namespace WorldCupConsole.Code;

internal class Program
{
    public void Test()
    {
        IMyInterface myImplementation1 = new MyImplementation();
        var average = myImplementation1.ComputeAverage(0, "");

        MyImplementation myImplementation2 = new MyImplementation();
        myImplementation2.DoSomething();

        var myClass1 = new MyClass1();
        var myProperty = myClass1.MyProperty;

        var myClass2 = new MyClass2(10, "MyProperty");
    }
}
