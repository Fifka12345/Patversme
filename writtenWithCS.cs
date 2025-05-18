using System;

public class Shelter
{
    public static void Main()
    {
        //data
		string shelterName;
		int dogs;
		int cats;
		int animals;
		int dogPercent;
		int catPercent;
		
        bool tryAgain = true;
        while (tryAgain)
        {
            try
            {
                Console.WriteLine("Please, write shelter name: ");
                shelterName = Console.ReadLine();

                Console.WriteLine("Please, enter amount of dogs: ");
                dogs = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please, enter amount of cats: ");
                cats = Convert.ToInt32(Console.ReadLine());

                animals = cats + dogs;
                dogPercent = (int)Math.Round((double)(100 * dogs) / animals);
                catPercent = (int)Math.Round((double)(100 * cats) / animals);

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
