using System.Linq;
using WorldCupConsole.EmployeeExercice;

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

    //SumArray
    public static int SumArray(int[] array,int n1,int n2)
    {
        int sum = 0;
        int n = array.Length;
        for(int i=0; i<n; i++)
        {
            sum += array[i];
        }
        return sum;
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

    private static int GetMonthNumber(string month) 
    {
        return month switch
        {
            "Janvier" => 1,
            "Février" => 2,
            "Mars" => 3,
            "Avril" => 4,
            "Mai" => 5,
            "Juin" => 6,
            "Juillet" => 7,
            "Août" => 8,
            "Septembre" => 9,
            "Octobre" => 10,
            "Novembre" => 11,
            "Décembre" => 12
        };
    }
    private static bool IsAfterMonth(string month1, string month2)
    {

        var monthNumber1 = GetMonthNumber(month1); 
        var monthNumber2 = GetMonthNumber(month2);
        if (monthNumber1 <= monthNumber2)
            return true;
        else return false;
    }

    // Compute accumulate result for example for October = October + November + December
    public static int Accumulate(Dictionary<string, int> annualResult, string month)
    { 
        int total = 0;
        foreach (var l in annualResult)
        {
            if (IsAfterMonth(month,l.Key) == true)
            {
                total = l.Value + total;
            }
        }
        return total;

    }
}
