using Recipe_Software;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook
{
    internal class Ingredients
    {
        RecipeSteps here = new RecipeSteps();
        RecipeApplication maybe = new RecipeApplication();

        List<string> IngrediantsList = new List<string>();
        List<string> Steps = new List<string>();
        List<string> RecipeList = new List<string>();

        public int ResetValue;
        //{ get; private set; }
        public object origValue;
        //{ get; private set; }   
        public int Ingredient;
        public int Quantity;
        //{ get; private set; }
        public string unitOfMeasurement;
        //{ get; private set; }
        public int numOfCalories;
        //{ get; private set; }
        public object NumCalories;
        //{ get; private set; }
        public List<string> RecipeTitle;
        //{ get; private set; }
        public object RecipenameList;

        public int sum1 { get; private set; }
        public int Food_Group { get; private set; }

        //{ get; private set; }

        public void EnterRecipe()
        {

            //access the  number of ingredients added by the user
            Console.WriteLine("Please enter the number of ingredients:");
            Ingredient = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < Ingredient; i++)
                for (int h = 0; h < IngrediantsList.Count; h++)
                {
                    {
                        //for loop which will loop according to the user input


                        //if (Features.Contains(NoOfINgredients))
                        //{
                        Console.WriteLine("Please enter the name for your recipe:");
                        string CurrentRecipeTitle = Console.ReadLine();
                        RecipeTitle.Add(CurrentRecipeTitle);
                        RecipeList.Add(CurrentRecipeTitle);

                        //Console.WriteLine("Please enter the name for your ingrediant:");
                        //Recipename = Console.ReadLine();
                        //RecipenameList.Add(Recipename);


                        Console.WriteLine("Please enter the quantity of your ingrediant");
                        Quantity = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Please enter your unit of measurement");
                        unitOfMeasurement = Console.ReadLine();

                        here.RecipeStep();

                        Console.WriteLine("Calories are the amount of energy released when your body breaks down (digests and absorbs) food."
                                          + "consistently exceeding your daily caloric needs can lead to weight gain and, in some cases, "
                                          + "contribute to the development of obesity.");

                        Console.WriteLine("*****************************************");
                        Console.WriteLine("Enter number of calories: ");
                        numOfCalories = Convert.ToInt32(Console.ReadLine());

                        //user is prompted to select a food group but have to refer to the calories before they continue
                        Console.WriteLine("Kindly select the food group that your ingredient belong to: "
                                        + "\n1. Carbohydrates (4 calories)"
                                        + "\n2. Proteins (4 calories)"
                                        + "\n3. Fats (9 calories)"
                                        + "\n4. Water"
                                        + "\n5. Vitamins and minerals"
                                        + "\n6. Dairy products (46 calories)"
                                        + "\n7. Vegetables and fruits");
                        Food_Group = Convert.ToInt32(Console.ReadLine());
                        

                        switch (Food_Group)
                        {
                            case 1:
                                Console.WriteLine("Food Group is:" + Food_Group + "" + "Carbohydrates");
                                break;
                            case 2:
                                Console.WriteLine("Food Group is:" + Food_Group + "" + "Protein");
                                break;
                            case 3:
                                Console.WriteLine("Food Group is:" + Food_Group + "" + "Fats");
                                break;
                            case 4:
                                Console.WriteLine("Food Group is:" + Food_Group + "" + "Vitamins");
                                break;
                            case 5:
                                Console.WriteLine("Food Group is:" + Food_Group + "" + "Fruits and vegetables");
                                break;
                            case 6:
                                Console.WriteLine("Food Group is:" + Food_Group + "" + "Dairy");
                                break;
                            case 7:
                                Console.WriteLine("Food Group is:" + Food_Group + "" + "Vegetables and fruits");

                                break;
                            default:
                                Console.WriteLine("Invalid!");
                                maybe.Menu();

                                break;
                        }


                        Console.WriteLine("*****************************************");
                        Console.ReadLine();
                    }
                }
        }

        //public void DisplayRecipe()
        //{
        //    //Display of the user input
        //    Console.WriteLine("Number of ingredients: " + NoOfINgredients);
        //    Console.WriteLine("Name of your recipe: " + Recipename);
        //    Console.WriteLine("Quantity: " + Quantity);
        //    Console.WriteLine("UnitOfMeasurement: " + unitOfMeasurement);
        //    Console.WriteLine("Number of steps: " + noOfSteps);
        //    Console.WriteLine("Steps Description:" + Description);
        //    Console.WriteLine("Scale Factor:" + sum1);

        //    Menue();
        //}

        public void DisplayRecipe()
        {
            Console.WriteLine(IngrediantsList);
            Console.WriteLine(Steps);
        }


        public void ResetValues()//stores arrays and resets
        {

            Console.WriteLine("Do you want to reset the values?"
                              + "\n1. Yes"
                              + "\n2. No");
            ResetValue = Convert.ToInt32(Console.ReadLine());


            if (ResetValue == 1)
            {

                ArrayList sam1 = new ArrayList();
                sam1.Add(Quantity);

                origValue = Quantity;
                Console.WriteLine("Original value: " + Quantity);
            }

            else
                if (ResetValue == 2)
            {
                Console.WriteLine("End");
                maybe.Menu();
            }
            
        }

        public void scaleFactor()
        {
            //Console.WriteLine("Enter the quantity of your recipe:");//prompts the user to enter the quantity
            //Quantity = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please select a scale factor:"
             + "\n1. 0.5(half)"
             + "\n2. 2(double)"
             + "\n3. 3(triple)");
            int Quantitys = Convert.ToInt32(Console.ReadLine());

            if (Quantitys == 1)
            {

                sum1 = (int)(Quantity * 0.5);
                Console.WriteLine(sum1);
            }
            else if (Quantitys == 2)
            {

                sum1 = Quantity * 2;
                Console.WriteLine(sum1);
            }
            if (Quantitys == 3)
            {

                sum1 = Quantity * 3;
                Console.WriteLine(sum1);
            }

            maybe.Menu();
        }

        public void ClearRecipe()
        {
            Console.WriteLine("Are you sure you want to clear all data and start a new recipe?"
                + "\n1. Yes"
                + "\n2. No");
            int confirmation = Convert.ToInt32(Console.ReadLine());

            if (confirmation == 1)
            {

                IngrediantsList.Clear();
                Console.WriteLine("Your data has been successfully cleared!");

            }
            else
            {
                maybe.Menu();
            }
        }

        public void ExitApp()
        {
            Console.WriteLine("We enjoyed having you, thank you for using our app");
        }

        //part2
        public void DisplayAlphabetically()
        {
            //display method sorts the recipe name users entered

            RecipeTitle.Sort();
            //RecipeList.Sort();

            Console.WriteLine("Recipes displayed alphabetically below:");

            foreach (string recipe in RecipeTitle)//foreach loop to sort recipe names
            {
                Console.WriteLine(recipe); //it is going to print all recipe names
            }

            maybe.Menu();
        }
}
}
