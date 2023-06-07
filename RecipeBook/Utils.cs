using Recipe_Software;
using System;
using System.Collections.Generic;

namespace RecipeBook
{
    delegate int CalculateTotalDelegate<T>(T cal);

    internal class Utils
    {
        private List<string> IngrediantsList = new List<string>();
        public int numOfCalories;
        private IEnumerable<object> NumberOfCalories;
        RecipeApplication maybe = new RecipeApplication();

        public object RecipeTitle;



        public void TotalCalories() //This class will calculate the total calorie using delegates
        {

            // Create an instance of the delegate
            CalculateTotalDelegate<int> calculateCalories = Calories;



            // Invoke the delegate to calculate the total
            int total = CalculateNumCalories(NumberOfCalories, calculateCalories);


            if (total <= 300)
            {
                Console.WriteLine("Total Calories:" + total);
                maybe.Menu();
            }
            else
            {
                Console.WriteLine("You have exceeded your total calories"
                                   + "Exceeding caloric needs by 300 calories per day can result in a weight "
                                   + "gain of approximately 0.1 kilograms (0.22 pounds) per week.");
                maybe.Menu();
            }
        }

        private int CalculateNumCalories(IEnumerable<object> numberOfCalories, CalculateTotalDelegate<int> calculateCalories)
        {
            throw new NotImplementedException();
        }

        private int CalculateNumCalories(int numberOfCalories, CalculateTotalDelegate<int> calculateCalories)
        {
            throw new NotImplementedException();
        }

        public int Calories(int numCalories)
        {
            return numCalories;
        }
        //collect the number of calories from generic list
        static int CalculateNumCalories<T>(IEnumerable<T> collection, CalculateTotalDelegate<T> calculateCalories)
        {
            int total = 0;

            foreach (T item in collection)
            {
                total += calculateCalories(item);
            }

            return total;
        }


    }
}
