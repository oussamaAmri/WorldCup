using NFluent;
using WorldCupConsole.AlgoCommon;

namespace TestProject;

public class UnitTest4
{
    [Fact]
    public void Common1()
    {
        var input1 = new[] { 4, 2, 6, 1, 7, 4, 5 };
        var input2 = new[] { 7, 3, 1 };

        var result = Algo4.Common(input1, input2);

        Check.That(result).Contains(7, 1);
    }

    [Fact]
    public void Common2()
    {
        var input1 = new[] { 4, 2 };
        var input2 = new[] { 6, 1, 7, 4, 5 };

        var result = Algo4.Common(input1, input2);

        Check.That(result).Contains(4);
    }

    [Fact]
    public void Common3()
    {
        var input1 = new[] { 4, 2, 6, };
        var input2 = new[] { 7, 3, 1 };

        var result = Algo4.Common(input1, input2);

        Check.That(result).IsEmpty();
    }
}