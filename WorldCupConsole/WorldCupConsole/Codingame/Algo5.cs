namespace WorldCupConsole.Codingame;

public static class Algo5
{
    /*
Objective
In this problem, you'll be filtering words based on the letters that they contain. Specifically, you'll be given an input list of words (all lowercase), along with a set of lowercase letters, and asked to filter out the words that don't contain any letters in the given set.
 
Implementation
Implement the method FilterWords(words, letters) which takes as input:
    an array of strings (words), with the words to filter.
    A string (letters), used to filter the words.

For example:
    words = ['the', 'dog', 'got', 'a', 'bone']
    letters = 'ae'
 
Your FilterWords method should return an array of strings from words that contain at least one letter in letters. The returned list should maintain the same ordering as in words.
For the above example, the correct output would be:
['the', 'a', 'bone']
     */
    public static string[] FilterWords(string[] words, string letters)
    {
        throw new NotImplementedException();
    }

    /*
Write the body of the Calc(array, n1, n2) method.

array is an array of integers. The n1 and n2 parameters are integers defined by the relation 0 <= n1 <= n2 < array.Length.

The Calc method should return the sum of the integers of array whose index belongs to the [n1; n2] interval.
     */
    public static int Calc(int[] array, int n1, int n2)
    {
        throw new NotImplementedException();
    }

    /*
GetSuperCustomers devra retourner une énumération de noms de clients à partir de la liste orders passée en paramètre.

Seuls les "supers" clients nous intéressent, sachant qu'un client de ce type est un client qui a dépensé au moins 100€. Attention : un même client peut avoir effectué plusieurs commandes. Essayez de prendre en compte cette éventualité.

Implémentez la méthode GetSuperCustomers en utilisant LINQ. Comme présenté dans le code de test, votre solution devra fonctionner si la liste orders est modifiée après l'appel à la méthode GetSuperCustomers (ne pas utiliser ToList()).

Exemple de résultat :
C3
C2
     */
    public static IEnumerable<string> GetSuperCustomers(List<Order> orders)
    {
        throw new NotImplementedException();
    }

    /*
Dans ce problème, on vous donne une liste d'entiers positifs et un entier distinct, k,
et on vous demande de trouver s'il existe une paire d'entiers dans la liste dont la somme est exactement k.
     */
    public static int[] FindSumPair(int[] numbers, int k)
    {
        var indexes = new int[2];

        for (var i = 0; i < numbers.Length; i++)
        {
            for (var j = i + 1; j < numbers.Length; j++)
            {
                var sum = numbers[i] + numbers[j];

                if (sum == k)
                {
                    indexes[0] = i;
                    indexes[1] = j;
                    break; // TODO attention le break sort uniquement de la 1ière boucle ! 
                }
            }
        }
        return indexes;
    }
}

public class Order
{
    public string Customer { get; set; }
    public decimal Price { get; set; }
}