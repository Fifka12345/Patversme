using System;

public class Program
{
    public static void Main()
    {
        bool tryAgain = true;
        while (tryAgain)
        {
            try
            {
                Console.WriteLine("Lūdzu, ievadiet patversmes nosaukumu");
                string shelterName = Console.ReadLine();

                Console.WriteLine("Lūdzu, ievadiet suņu skaitu");
                int dogs = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Lūdzu, kaķu skaitu");
                int cats = Convert.ToInt32(Console.ReadLine());

                int animals = cats + dogs;

                int dogPercent = (int)Math.Round((double)(100 * dogs) / animals);
                int catPercent = (int)Math.Round((double)(100 * cats) / animals);

                Console.WriteLine($"Patversme {shelterName} rūpējas par {animals} dzīvniekiem. Suņi veido {dogPercent}% no visiem dzīvniekiem, bet kaķi veido {catPercent}% no visiem dzīvniekiem.");
                tryAgain = false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Notika ķļūda: " + e.Message);
            }
        }
    }
}
