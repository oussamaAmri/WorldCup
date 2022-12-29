using Microsoft.VisualStudio.TestPlatform.Utilities;
using NFluent;
using WorldCupConsole;

namespace TestProject;

public class UnitTest1
{
    [Theory]
    [InlineData(1, "1")]
    [InlineData(3, "Fizz")]
    [InlineData(5, "Buzz")]
    [InlineData(15, "FizzBuzz")]
    public void FizzBuzz(int input, string output)
    {
        var result = Algo.FizzBuzz(input);

        Check.That(result).IsEqualTo(output);
    }

    [Fact]
    public void Sort()
    {
        var array = new int[]
        {
            10, 5, 8, 3, 4, 1, 3
        };

        var result = Algo.Sort(array);

        Check.That(result).ContainsExactly(1, 3, 3, 4, 5, 8, 10);
    }

    [Fact]
    public void FilterString()
    {
        var input = "La Coupe du monde de football 2022 est la 22e édition de ce tournoi quadriennal. Organisée par la FIFA, elle se déroule au Qatar du 20 novembre au 18 décembre 2022, jour de la fête nationale.";

        var result = Algo.FilterString(input);

        Check.That(result).ContainsExactly("football", "quadriennal", "Organisée", "novembre", "décembre", "nationale");
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(2, 1)]
    [InlineData(10, 55)]
    [InlineData(15, 610)]
    [InlineData(18, 2_584)]
    public void Fibonacci(int input, int output)
    {
        var result = Algo.Fibonacci(input);

        Check.That(result).IsEqualTo(output);
    }

    [Fact]
    public void CreateList()
    {
        var result = Algo.CreateList();

        Check.That(result).ContainsExactly(1, 2, 3);
    }

    [Fact]
    public void AddElementToList()
    {
        var input = new List<int> { 1, 2, 3 };

        var result = Algo.AddElementToList(input);

        Check.That(result).ContainsExactly(1, 2, 3, 4);
    }

    [Fact]
    public void AddElementToArray()
    {
        var input = new int[]{ 1, 2, 3 };

        var result = Algo.AddElementToArray(input);

        Check.That(result).ContainsExactly(1, 2, 3, 4);
    }

    [Fact]
    public void FilterDictionaryByKey()
    {
        var input = new Dictionary<int, string>
        {
            [1] = "Red",
            [2] = "Blue",
            [3] = "Green",
            [4] = "Orange",
            [5] = "Pink",
        };

        var result = Algo.FilterDictionaryByKey(input);

        Check.That(result).ContainsExactly(KeyValuePair.Create(5, "Pink"));
    }

    [Fact]
    public void FilterDictionaryByValue()
    {
        var input = new Dictionary<int, string>
        {
            [1] = "Red",
            [2] = "Red",
            [3] = "Green",
            [4] = "Green",
            [5] = "Green",
        };

        var result = Algo.FilterDictionaryByValue(input);
        Check.That(result).ContainsExactly(KeyValuePair.Create(1, "Red"), KeyValuePair.Create(2, "Red"));
    }

    [Fact]
    public void ToDictionary()
    {
        var input = new List<string> { "Green", "Red", "Blue", "Red", "Green", "Purple", "Green" };

        var result = Algo.ToDictionary(input);

        var dicToCheck = result.OrderBy(x => x.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
        Check.That(dicToCheck).ContainsExactly(
            KeyValuePair.Create("Blue", 1),
            KeyValuePair.Create("Green", 3),
            KeyValuePair.Create("Red", 2),
            KeyValuePair.Create("Purple", 1));
    }

    [Theory]
    [InlineData(0, 7)]
    [InlineData(1, 14)]
    [InlineData(2, 15)]
    [InlineData(3, 11)]
    [InlineData(4, 4)]
    public void Sum(int index, int output)
    {
        var input = new int[] { 2, 5, 7, 3, 1 };

        var result = Algo.Sum(input, index);

        Check.That(result).IsEqualTo(output);
    }
}