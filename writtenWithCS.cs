using System;

public class Shelter
{
    public static void Main()
    {
        bool tryAgain = true;
        while (tryAgain)
        {
            try
            {
                Console.WriteLine("Please, write shelter name: ");
                string shelterName = Console.ReadLine();

                Console.WriteLine("Please, enter amount of dogs: ");
                int dogs = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please, enter amount of cats: ");
                int cats = Convert.ToInt32(Console.ReadLine());

                int animals = cats + dogs;
                int dogPercent = (int)Math.Round((double)(100 * dogs) / animals);
                int catPercent = (int)Math.Round((double)(100 * cats) / animals);

                Console.WriteLine($"Shelter: {shelterName} takes care of {animals} animals. Dogs make {dogPercent}% in the shelter, but cats make {catPercent}% in the shelter.");
                tryAgain = false;
            }
            catch (Exception e)
            {
                Console.WriteLine("An Error occurred: " + e.Message);
            }
        }
    }
}
