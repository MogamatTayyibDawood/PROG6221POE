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

namespace PROG6221POE
{
    public class Program
    {
        static void Main(string[] args)
        {
            RecipeManager recipeManager = new RecipeManager(); //craeting instance of RecipeManager
            recipeManager.RecipeExceedsCalories += RecipeExceedsCaloriesHandler; //subscribing to RecipeExceedsCalories event

            while (true) //Starting a loop
            {
                Console.WriteLine("Welcome to the Recipe App"); // displaying a welcome message
                Console.WriteLine("Select an option:"); //telling user to select an option
                Console.WriteLine("1. Add Recipe"); //1st option is to Add Recipe
                Console.WriteLine("2. Add Ingredients to Recipe"); //2nd option is to Add ingredients to recipe
                Console.WriteLine("3. Display Recipes"); //3rd option is to Display Recipes
                Console.WriteLine("4. Display Recipe"); //4th option is to Display Recipe
                Console.WriteLine("5. Exit"); //5th option is to Exit

                if (!int.TryParse(Console.ReadLine(), out int choice)) // reads user input and parsing it as an integer
                {
                    Console.WriteLine("Invalid choice. Please try again."); //displays error message for invalid input.
                    continue;
                }

                switch (choice) //switches choices based on users choice
                {
                    case 1: // option 1
                        Console.Write("Enter the name of the recipe: "); //prompts user to enter naem of recipe
                        string recipeName = Console.ReadLine();
                        recipeManager.AddRecipe(recipeName);
                        break;

                    case 2: //option 2
                        Console.Write("Enter the name of the recipe: "); //prompts user to enter name of recipe
                        string recipeToAddTo = Console.ReadLine();
                        Console.Write("Enter the name of the ingredient: "); //prompts user to enter name of ingredient
                        string ingredientName = Console.ReadLine();
                        Console.Write("Enter the quantity of the ingredient: "); //prompts user to enter quantity of ingredient
                        if (!double.TryParse(Console.ReadLine(), out double quantity))
                        {
                            Console.WriteLine("Invalid quantity. Please try again.");
                            continue;
                        }
                        Console.Write("Enter the unit of the ingredient: "); //prompts user to enter unit of ingredient
                        string unit = Console.ReadLine();
                        Console.Write("Enter the calories of the ingredient: "); //prompts user to enter the calories of ingredient
                        if (!double.TryParse(Console.ReadLine(), out double calories))
                        {
                            Console.WriteLine("Invalid calories. Please try again.");
                            continue;
                        }
                        Console.Write("Enter the food group of the ingredient: "); //prompts user to enter food group of ingredient
                        string foodGroup = Console.ReadLine();
                        recipeManager.AddIngredientToRecipe(recipeToAddTo, ingredientName, quantity, unit, calories, foodGroup); //adding ingredeint to recipe
                        break;


                    case 3: //option 3
                        Console.WriteLine("Recipes:"); //shows message that recipes will be displayed
                        recipeManager.DisplayRecipes();
                        break;

                    case 4: // option 4
                        Console.Write("Enter the name of the recipe to display: "); //prompts user to enter name of recipe to display
                        string recipeToDisplay = Console.ReadLine();
                        recipeManager.DisplayRecipe(recipeToDisplay);
                        break;

                    case 5: //option 5
                        return; //exit program

                    default:
                        Console.WriteLine("Invalid choice. Please try again."); //error message ofr invalid input
                        break;
                }

                Console.WriteLine();
            }
        }

    
        static void RecipeExceedsCaloriesHandler(Recipe recipe)  //Handler for when recipe exceeds 300 calories
        {
            Console.WriteLine($"Warning: {recipe.Name} exceeds 300 calories!"); //displays warning message.
        }
    }
}
//------------------------------------------...ooo000 END OF FILE 000ooo...------------------------------------------------------//