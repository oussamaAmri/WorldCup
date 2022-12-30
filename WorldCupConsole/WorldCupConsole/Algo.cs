using System.Linq;

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
        List<int> list = new List<int> { 1,2,3};
        return list;
    }

    // Add element to a list
    public static List<int> AddElementToList(List<int> input)
    {
        List<int> listAdd = new List<int> { 4};
        foreach(var element in input)
        {
            listAdd.Add(element);
        }
        listAdd.Sort();
        return listAdd;
    }

    // Add element to an array
    public static int[] AddElementToArray(int[] input)
    {
        var elementArray = new int[4];
        for (int i = 0; i < input.Length; i++)
        {
                elementArray[i] = input[i];
        }
        elementArray[elementArray.Length-1] = 4;
        return elementArray;
    }

    // Filter dictionary by key >= 5
    public static Dictionary<int, string> FilterDictionaryByKey(Dictionary<int, string> input)
    {
        var filtreKey = new Dictionary<int, string>();
        filtreKey = input.Where(x=>x.Key >= 5).OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        return filtreKey;
        
    }

    // Filter dictionary by value == Red
    public static Dictionary<int, string> FilterDictionaryByValue(Dictionary<int, string> input)
    {
        var filtreValue = new Dictionary<int, string>();
        filtreValue = input.Where(x => x.Value == "Red").ToDictionary(x => x.Key, x => x.Value);
        return filtreValue;
    }

    // Create dictionary
    public static Dictionary<string, int> ToDictionary(List<string> input)
    {
        var CountValue = new Dictionary<string, int>();
        foreach(var l in input)
        {
            if(CountValue.ContainsKey(l) == true)
            {
                CountValue[l] = CountValue[l] + 1;
            }
            else
            { 
                CountValue.Add(l,1);
            }
        }
           
        return CountValue;
    }

    // Return input[index - 1] + input[index] + input[index + 1]
    public static int Sum(int[] input, int index)
    {
        int sum = 0;
        int n = input.Length;
            if (index > 0 && index < n-1)
            {
                sum = input[index - 1] + input[index] + input[index + 1];
            }
            else if (index <= 0)
            {
                sum = input[index] + input[index+1];
            }
            else if (index >= n-1)
            {
                sum = input[index - 1] + input[index];
            }
        return sum;
    }
}
