using System.Globalization;

namespace WorldCupConsole;

public static class Algo
{
    // FizzBuzz
    public static string FizzBuzz(int i)
    {
        if (i % 3 == 0 && i % 5 == 0) return "FizzBuzz";
        else if (i % 3 == 0) return "Fizz";
        else if (i % 5 == 0) return "Buzz";
        else return i.ToString();
    }

    // Sort input
    public static int[] Sort(int[] input)
    {
        Array.Sort(input);
        return input;
    }

    // Return words with length more than 7 characters
    public static List<string> FilterString(string input)
    {
        /*var list = new List<string>();
        string[] substring = input.Split(" ");
        foreach(var s in substring)
        {
            if(s.Length > 7)
            {
                string str = s.Replace(".", "");
                list.Add(str);    
            }
        }
        return list;*/
        string[] substring = input.Split();
        return substring.Where(w => w.Length > 7).Select(s =>s.Replace(".","")).ToList();
    }




    // Compute Fibonacci
    public static int Fibonacci(int input)
    {
        int w;
        if (input <= 0) return 0;
        if (input == 1) return 1;
        int u = 0;
        int v = 1;
        for(int i=2;i<=input;i++)
        {
            w = u + v;
            u = v;
            v = w;
        };
        return v;
    }

    // Create a list
    public static List<int> CreateList()
    {
        throw new NotImplementedException();
    }

    // Add element to a list
    public static List<int> AddElementToList(List<int> input)
    {
        throw new NotImplementedException();
    }

    // Add element to an array
    public static int[] AddElementToArray(int[] input)
    {
        throw new NotImplementedException();
    }

    // Filter dictionary by key >= 5
    public static Dictionary<int, string> FilterDictionaryByKey(Dictionary<int, string> input)
    {
        throw new NotImplementedException();
    }

    // Filter dictionary by value == Red
    public static Dictionary<int, string> FilterDictionaryByValue(Dictionary<int, string> input)
    {
        throw new NotImplementedException();
    }

    // Create dictionary
    public static Dictionary<string, int> ToDictionary(List<string> input)
    {
        throw new NotImplementedException();
    }

    // Return input[index - 1] + input[index] + input[index + 1]
    public static int Sum(int[] input, int index)
    {
        throw new NotImplementedException();
    }
}
