using NFluent;
using WorldCupConsole;

namespace TestProject;

public class UnitTest2
{
    [Fact]
    public void MergeArray()
    {
        var input1 = new[] { 1, 4, 5, 7, 9 };
        var input2 = new[] { 2, 3, 4, 6 };

        var result = Algo2.MergeArray(input1, input2);

        Check.That(result).ContainsExactly(1, 2, 3, 4, 5, 6, 7, 9);
    }

    [Theory]
    [InlineData("La coupe du monde de football 2022 est la 22e édition de ce tournoi quadriennal.", 'c', 2)]
    [InlineData("La mascotte officielle de la compétition est dévoilée le 1er avril 2022.", 'a', 4)]
    public void CountCharaters(string input1, char input2, int output)
    {
        var result = Algo2.CountCharaters(input1, input2);

        Check.That(result).IsEqualTo(output);
    }

    [Theory]
    [InlineData("La Coupe du monde de football 2022 est la 22e édition de ce tournoi quadriennal.", 15)]
    [InlineData("La mascotte officielle de la compétition est dévoilée le 1er avril 2022.", 12)]
    public void CountWords(string input, int output)
    {
        var result = Algo2.CountWords(input);

        Check.That(result).IsEqualTo(output);
    }

    [Theory]
    [InlineData("Février", 92)]
    [InlineData("Avril", 75)]
    [InlineData("Août", 48)]
    [InlineData("Octobre", 22)]
    [InlineData("Décembre", 7)]
    public void Accumulate(string input, int output)
    {
        var annualResult = new Dictionary<string, int>
        {
            ["Janvier"] = 20,
            ["Février"] = 5,
            ["Mars"] = 12,
            ["Avril"] = 2,
            ["Mai"] = 5,
            ["Juin"] = 8,
            ["Juillet"] = 12,
            ["Août"] = 16,
            ["Septembre"] = 10,
            ["Octobre"] = 1,
            ["Novembre"] = 14,
            ["Décembre"] = 7,
        };

        var result = Algo2.Accumulate(annualResult, input);

        Check.That(result).IsEqualTo(output);
    }
}