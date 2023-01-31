using NFluent;
using WorldCupConsole.Codingame;

namespace TestProject;

public class UnitTest5
{
    [Fact(DisplayName = "an animal is not an object is a human")]
    public void FilterWords_1()
    {
        var words = new[] { "an", "animal", "is", "not", "an", "object", "is", "a", "human" };
        var letters = "ae";

        var result = Algo5.FilterWords(words, letters);

        Check.That(result).ContainsExactly("an", "animal", "object", "a", "human");
    }

    [Fact(DisplayName = "dreamers see no light at the end")]
    public void FilterWords_2()
    {
        var words = new[] { "dreamers", "see", "no", "light", "at", "the", "end" };
        var letters = "dt";

        var result = Algo5.FilterWords(words, letters);

        Check.That(result).ContainsExactly("dreamers", "light", "at", "the");
    }

    [Fact(DisplayName = "to be or not to be")]
    public void FilterWords_3()
    {
        var words = new[] { "to", "be", "or", "not", "to", "be" };
        var letters = "o";

        var result = Algo5.FilterWords(words, letters);

        Check.That(result).ContainsExactly("to", "or", "not");
    }

    [Fact]
    public void Calc_1()
    {
        var array = new[] { 6, 2, 7, 3, 4, 9 };
        var n1 = 1;
        var n2 = 3;

        var result = Algo5.Calc(array, n1, n2);

        Check.That(result).IsEqualTo(12);
    }

    [Fact]
    public void Calc_2()
    {
        var array = new[] { 6, 2, 7, 3, 4, 9 };
        var n1 = 0;
        var n2 = 1;

        var result = Algo5.Calc(array, n1, n2);

        Check.That(result).IsEqualTo(8);
    }

    [Fact]
    public void Calc_3()
    {
        var array = new[] { 6, 2, 7, 3, 4, 9 };
        var n1 = 3;
        var n2 = 5;

        var result = Algo5.Calc(array, n1, n2);

        Check.That(result).IsEqualTo(16);
    }

    [Fact]
    public void GetSuperCustomers_1()
    {
        var orders = new List<Order>();
        var superCustomers = Algo5.GetSuperCustomers(orders);

        orders.Add(new Order { Customer = "C3", Price = 125m });
        orders.Add(new Order { Customer = "C2", Price = 150m });
        orders.Add(new Order { Customer = "C1", Price = 50m });
        orders.Add(new Order { Customer = "C1", Price = 25m });

        Check.That(superCustomers).Contains("C3", "C2");
    }

    [Fact]
    public void GetSuperCustomers_2()
    {
        var orders = new List<Order>();
        var superCustomers = Algo5.GetSuperCustomers(orders);

        orders.Add(new Order { Customer = "C3", Price = 25m });
        orders.Add(new Order { Customer = "C2", Price = 99m });
        orders.Add(new Order { Customer = "C1", Price = 80m });
        orders.Add(new Order { Customer = "C1", Price = 90m });

        Check.That(superCustomers).Contains("C1");
    }
}