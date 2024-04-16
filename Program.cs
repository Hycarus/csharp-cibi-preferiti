namespace csharp_cibi_preferiti;

class Program
{
    static void Main(string[] args)
    {
        string[] favouriteFoods = { "Torta alle mele", "Lasagne", "Pollo fritto", "Sushi", "Patatine", "Pizza" };
        Console.WriteLine($"Lunghezza della Classifica: {favouriteFoods.Length}");

        for(int i = 0; i < favouriteFoods.Length; i++)
        {
            Console.WriteLine($"{i + 1} {favouriteFoods[i]}");
        }

        Console.WriteLine($"Cibo preferito: {favouriteFoods[0]}");

        Console.WriteLine($"Cibo preferito (ma non troppo): {favouriteFoods[favouriteFoods.Length - 1]}");
    }
}

