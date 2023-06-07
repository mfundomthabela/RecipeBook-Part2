using Recipe_Software;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook
{
    internal class RecipeSteps
    {
        int noOfSteps;
        string Description;

        RecipeApplication maybe = new RecipeApplication();

        public void RecipeStep()
        {
            Console.WriteLine("*****************************************");
            Console.ReadLine();

            Console.WriteLine("Please enter the number of your steps:");
            noOfSteps = Convert.ToInt32(Console.ReadLine());

            // loop for the number of steps the user is going to input
            for (int m = 0; m < noOfSteps; m++)
            {

                Console.WriteLine("Please enter the description of your steps:");
                Description = Console.ReadLine();
            }

            maybe.Menu();

        }
    }
}
