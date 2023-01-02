namespace WorldCupConsole;

public class Algo2
{
    // {1, 4, 5, 7, 9} and {2, 3, 4, 6} => {1, 2, 3, 4, 5, 6, 7, 9}
    public static int[] MergeArray(int[] array1, int[] array2)
    {
        int[] mergeArray;
        mergeArray = array1.Concat(array2).Distinct().ToArray();
        Array.Sort(mergeArray);
        return mergeArray;
    }

    // Count c in input
    public static int CountCharaters(string input, char c)
    {
        int freq = input.Count(f => (f == c));
        return freq;    
    }

    // Count word in input
    public static int CountWords(string input)
    {
        int cpt = 1;
        foreach(char c in input)
        {
            if(c == ' ')
            {
                cpt++;
            }
        }
        return cpt;
    }

    // Compute accumulate result for example for October = October + November + December
    public static int Accumulate(Dictionary<string, int> annualResult, string month)
    {
        throw new NotImplementedException();
    }
}
