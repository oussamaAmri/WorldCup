using NFluent;
using WorldCupConsole.LinqKata;
using WorldCupConsole.ParkingExercice;

namespace TestProject;

public class UnitTest3
{
    [Fact]
    public void GetElementA_1()
    {
        var input = new[]
        {
            "5", "3", "7", "9", "3"
        };

        var result = Algo3.GetElementA(input);

        Check.That(result).IsEqualTo("5");
    }

    [Fact]
    public void GetElementA_2()
    {
        var input = Enumerable.Empty<string>();

        Check.ThatCode(() => Algo3.GetElementA(input)).Throws<InvalidOperationException>();
    }

    [Fact]
    public void GetElementB_1()
    {
        var input = new[]
        {
            "5", "3", "7", "9", "3"
        };

        var result = Algo3.GetElementB(input);

        Check.That(result).IsEqualTo("5");
    }

    [Fact]
    public void GetElementB_2()
    {
        var input = Enumerable.Empty<string>();

        var result = Algo3.GetElementB(input);

        Check.That(result).IsNull();
    }

    [Fact]
    public void GetElementC_1()
    {
        var input = new[]
        {
            "5"
        };

        var result = Algo3.GetElementC(input);

        Check.That(result).IsEqualTo("5");
    }

    [Fact]
    public void GetElementC_2()
    {
        var input = Enumerable.Empty<string>();

        Check.ThatCode(() => Algo3.GetElementC(input)).Throws<InvalidOperationException>();
    }

    [Fact]
    public void GetElementC_3()
    {
        var input = new[]
        {
            "5", "8"
        };

        Check.ThatCode(() => Algo3.GetElementC(input)).Throws<InvalidOperationException>();
    }

    [Fact]
    public void GetElementD_1()
    {
        var input = new[]
        {
            "5"
        };

        var result = Algo3.GetElementD(input);

        Check.That(result).IsEqualTo("5");
    }

    [Fact]
    public void GetElementD_2()
    {
        var input = Enumerable.Empty<string>();

        var result = Algo3.GetElementD(input);

        Check.That(result).IsNull();
    }

    [Fact]
    public void GetElementD_3()
    {
        var input = new[]
        {
            "5", "8"
        };

        Check.ThatCode(() => Algo3.GetElementD(input)).Throws<InvalidOperationException>();
    }

    [Fact]
    public void Filter()
    {
        var input = new[]
        {
            7, 3, 6, 2, 7, 8, 9, 4
        };

        var result = Algo3.Filter(input);

        Check.That(result).ContainsExactly(6, 2, 8, 4);
    }

    [Fact]
    public void TranslateA()
    {
        var input = new[]
        {
            new Code1 { Id1 = 1, Name1 = "Name1" },
            new Code1 { Id1 = 2, Name1 = "Name2" },
        };

        var result = Algo3.TranslateA(input);

        Check.That(result.Extracting(r => r.Id2)).ContainsExactly(1, 2);
        Check.That(result.Extracting(r => r.Name2)).ContainsExactly("Name1", "Name2");
    }

    [Fact]
    public void TranslateB()
    {
        var input = new[]
        {
            new[] { "4", "2" },
            new[] { "8", "5" }
        };

        var result = Algo3.TranslateB(input);

        Check.That(result).ContainsExactly("4", "2", "8", "5");
    }
}