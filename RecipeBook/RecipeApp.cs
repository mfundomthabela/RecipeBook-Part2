using RecipeBook;
using System;
using System.Collections.Generic;

namespace Recipe_Software
{
    class RecipeApplication
    {
        List<string> RecipbookList = new List<string>();

        Ingredients sam = new Ingredients();
        Utils s = new Utils();
        RecipeSteps n = new RecipeSteps();
        Recipe f = new Recipe();

        public void Menu(Ingredients sam, Utils s, RecipeSteps n, Recipe f)
        {

            Console.WriteLine("******************************");
            Console.WriteLine("Please select your menu:"
                             + "\n1. Enter Recipe"
                             + "\n2. Scale Factor"
                             + "\n3. Display Recipe"
                             + "\n4. Reset Quantity"
                             + "\n5. Clear Recipe"
                             + "\n6. Display Alphabetically"
                             + "\n7. Search Recipe Name"
                             + "\n8. Total Calories"
                             + "\n9. Exit Application");

            int menu = Convert.ToInt32(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    sam.EnterRecipe();
                    break;
                case 2:
                    sam.scaleFactor();
                    break;
                case 3:
                    sam.DisplayRecipe();
                    break;
                case 4:
                    sam.ResetValues();
                    break;
                case 5:
                    sam.ClearRecipe();
                    break;
                case 6:
                    sam.DisplayAlphabetically();
                    break;
                case 7:
                    f.SearchRecipeName();
                    break;
                case 8:
                    s.TotalCalories();
                    break;
                case 9:
                    sam.ExitApp();
                    break;
            }
            Console.WriteLine("---------------------------------");
        }

        static void Main(string[] args)
        {
            Menu();
        }

        
    }
}
