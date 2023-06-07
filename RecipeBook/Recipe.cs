using Recipe_Software;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace RecipeBook
{

    internal class Recipe
    {
        List<string> IngrediantsList = new List<string>();
        List<string> RecipeList = new List<string>();
        RecipeApplication maybe = new RecipeApplication();
        Ingredients sam = new Ingredients();

        public List<string> RecipeTitle;
        public List<string> search;
        public void SearchRecipeName()
        {

            //prompts user to enter name they are looking for
            Console.WriteLine("Enter the name of your recipe you are searching for:");
            string search = Console.ReadLine();//prompts user to enter recipe they looking for

            //if statement to find search method
            if (RecipeTitle.Contains(search))
            {
                //Console.WriteLine("We have found it"
                //    + "\n.Recipe Name:" + RecipeName
                //    + "\n.Ingredient Name:" + Name
                //    + "\n.Quantity:" + Quantity
                //    + "\n.Unit Measurement:" + unitOfMeasurement
                //    + "\n. Scale factor: " + sum
                //    + "\n.Number of calories:" + numOfCalories
                //    + "\n.Food Group:" + Food_Group
                //    + "\n.Number Of Steps:" + numOfSteps
                //    + "\n.Description:" + Description);

                Console.Write(search);
            }
            else
            {
                // if recipe is name is not found , then it will prompt the user to re-search the name
                Console.WriteLine("Recipe Name not found");
                Console.WriteLine("Would you like to return to menu or exit app"
                                + "\n1. Return to menu "
                                + "\n2.Exit App ");
                int Rertu = Convert.ToInt32(Console.ReadLine());

                switch (Rertu)
                {
                    case 1:
                        maybe.Menu();
                        break;
                    case 2:
                        sam.ExitApp();

                        break;

                }
            }
        }
    }
}
