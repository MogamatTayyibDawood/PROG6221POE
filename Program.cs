// Mogamat Tayyib Dawood
// ST10132915
// Group 1

// References:
// https://www.youtube.com/watch?v=GhQdlIFylQ8&list=PL6n9fhu94yhVm6S8I2xd6nYzpassportdhAqP
// https://www.tutorialspoint.com/cprogramming/index.htm
// https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221POE
{
    class Program
    {
        static void Main(string[] args)
        {
            RecipeManager recipeManager = new RecipeManager();

            // Loop that runs till user exits app
            while (true)
            {
                //Different options for user
                Console.WriteLine("Welcome to the Recipe App");
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Add ingredient");
                Console.WriteLine("2. Add step");
                Console.WriteLine("3. Display Recipe");
                Console.WriteLine("4. Scale Recipe");
                Console.WriteLine("5. Reset Recipe");
                Console.WriteLine("6. Clear Recipe");
                Console.WriteLine("7. Exit");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    //if user leaves empty or invalid input, then:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
                }

                switch (choice)
                {
                    case 1:

                        //gets ingredients details from user
                        Console.Write("Enter name of ingredient: ");
                        string ingName = Console.ReadLine();
                        Console.Write("Enter quantity of ingredient: ");
                        if (!double.TryParse(Console.ReadLine(), out double ingQuantity))
                        {
                            //quantity is invalid, not int:
                            Console.WriteLine("Invalid quantity. Please try again.");
                            continue;
                        }
                        Console.Write("Enter unit of ingredient: ");
                        string ingUnit = Console.ReadLine();
                        recipeManager.AddIngredient(ingName, ingQuantity, ingUnit);
                        break;

                    case 2:

                        //gets a description and steps for recipe from user
                        Console.Write("Enter step description: ");
                        string stepDescrip = Console.ReadLine();
                        recipeManager.AddStep(stepDescrip);
                        break;

                    case 3:

                        //displays recipe, checks first if recipe is empty
                        if (recipeManager.GetIngredientCount() == 0 || recipeManager.GetStepCount() == 0)
                        {
                            Console.WriteLine("The recipe is empty. Please add ingredients and steps first.");
                        }
                        else
                        {
                            //line to actually display recipe
                            recipeManager.DisplayRecipe();
                        }
                        break;

                    case 4:
                        //scaling for recipe, checks first if recipe is empty
                        if (recipeManager.GetIngredientCount() == 0 || recipeManager.GetStepCount() == 0)
                        {
                            Console.WriteLine("The recipe is empty. Please add ingredients and steps first.");
                            continue;
                        }

                        Console.Write("Enter the scale factor (0.5, 2, 3, etc.): ");
                        if (!double.TryParse(Console.ReadLine(), out double scaleFactor) || scaleFactor <= 0)
                        {

                            //if scaling invalid, this message:
                            Console.WriteLine("Invalid scale factor. Please try again.");
                            continue;
                        }
                        recipeManager.ScaleRecipe(scaleFactor);
                        break;

                    case 5:

                        //resetting the recipe, checks first if recipe is empty
                        if (recipeManager.GetIngredientCount() == 0 || recipeManager.GetStepCount() == 0)
                        {
                            Console.WriteLine("The recipe is empty. There's nothing to reset.");
                        }
                        else
                        {

                            //line to reset recipe
                            recipeManager.ResetRecipe();
                        }
                        break;

                    case 6:

                        //clear recipe
                        recipeManager.ClearRecipe();
                        Console.WriteLine("Recipe cleared.");
                        break;

                    case 7:

                        //exit application
                        return;

                    default:

                        //this line handles any invalid choices by user
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                //makes sure user input is spaced nicely from each other
                Console.WriteLine();
            }
        }
    }
}

