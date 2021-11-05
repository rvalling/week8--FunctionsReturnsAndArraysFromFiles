using System;

namespace FridayRandomReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomFood, randomDrink, randomMovie;
            string[] foods = { "chiken wings", "pizza", "sushi", "popcorn", "salad" };
            string[] drinks = { "apple juice", "coke", "fanta", "Sprite" };
            string[] movie = { "Die Hard", "Home Alone", "A-Team", "Friends" };

            randomFood = PickRandomElementFromArray(foods);
            randomDrink = PickRandomElementFromArray(drinks);
            randomMovie = PickRandomElementFromArray(movie);
            Console.WriteLine($"Tonight you will have some {randomFood} with {randomDrink} and watch {randomMovie}");
        }

        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            return randomIndex;
        }
        
        private static string PickRandomElementFromArray(string[] someArray)
        {
            string randomElement = someArray[GenerateRandomIndex(someArray)];
            return randomElement;
            
        }
    }
}
