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

            while (true) // Infinite loop for the menu
            {
                Console.WriteLine("Welcome to the Recipe App"); // displaying a welcome message
                Console.WriteLine("Select an option:"); //telling user to select an option
                Console.WriteLine("1. Add Recipe"); //1st option is to Add Recipe
                Console.WriteLine("2. Add Ingredients to Recipe"); //2nd option is to Add ingredients to recipe
                Console.WriteLine("3. Display Recipes"); //3rd option is to Display Recipes
                Console.WriteLine("4. Display Recipe"); //4th option is to Display Recipe
                Console.WriteLine("5. Add Steps to Recipe");
                Console.WriteLine("6. Scale Recipe"); //********************
                Console.WriteLine("7. Reset Recipe");
                Console.WriteLine("8. Clear Data");
                Console.WriteLine("9. Exit"); //9th option is to Exit

                if (!int.TryParse(Console.ReadLine(), out int choice))  // Try to parse user input as an integer
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;  // Invalid input, continue the loop
                }

                switch (choice)  // Handle the user's choice
                {
                    case 1:
                        Console.Write("Enter the name of the recipe: ");
                        string recipeName = Console.ReadLine();
                        recipeManager.AddRecipe(recipeName);  // Add a new recipe
                        break;

                    case 2:
                        AddIngredientToRecipe(recipeManager);  // Add an ingredient to a recipe
                        break;

                    case 3:
                        Console.WriteLine("Recipes:");
                        recipeManager.DisplayRecipes();  // Display all recipes
                        break;

                    case 4:
                        Console.Write("Enter the name of the recipe to display: ");
                        string recipeToDisplay = Console.ReadLine();
                        recipeManager.DisplayRecipe(recipeToDisplay);  // Display a specific recipe
                        break;

                    case 5:
                        AddStepsToRecipe(recipeManager);  // Add steps to a recipe
                        break;

                    case 6:
                        ScaleRecipe(recipeManager);  // Scale a recipe
                        break;

                    case 7:
                        ResetRecipe(recipeManager);  // Reset a recipe
                        break;

                    case 8:
                        recipeManager.ClearData();  // Clear all data
                        Console.WriteLine("All data cleared.");
                        break;

                    case 9:
                        Console.WriteLine("Are you sure you want to exit? (Y/N)");
                        string exitConfirmation = Console.ReadLine().ToUpper();
                        if (exitConfirmation == "Y")
                            return;  // Exit the application
                        else if (exitConfirmation == "N")
                            break;  // Do nothing, continue the loop
                        else
                        {
                            Console.WriteLine("Invalid input. Please try again.");
                            continue;  // Invalid input, continue the loop
                        }

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void AddIngredientToRecipe(RecipeManager recipeManager)
        {
            Console.Write("Enter the name of the recipe: ");
            string recipeToAddTo = Console.ReadLine();
            Console.Write("Enter the name of the ingredient: ");
            string ingredientName = Console.ReadLine();
            Console.Write("Enter the quantity of the ingredient: ");
            if (!double.TryParse(Console.ReadLine(), out double quantity))  // Parse quantity as double
            {
                Console.WriteLine("Invalid quantity. Please try again.");
                return;  // Invalid input, return
            }
            Console.Write("Enter the unit of the ingredient: ");
            string unit = Console.ReadLine();
            Console.Write("Enter the calories of the ingredient: ");
            if (!double.TryParse(Console.ReadLine(), out double calories))  // Parse calories as double
            {
                Console.WriteLine("Invalid calories. Please try again.");
                return;  // Invalid input, return
            }

            Console.WriteLine("Select the food group of the ingredient:");
            Console.WriteLine("1. Vegetables and fruits");
            Console.WriteLine("2. Starchy foods");
            Console.WriteLine("3. Proteins");
            Console.WriteLine("4. Dairy");
            Console.WriteLine("5. Fats and sugars");
            string foodGroup = GetFoodGroupSelection();  // Get the food group selection

            recipeManager.AddIngredientToRecipe(recipeToAddTo, ingredientName, quantity, unit, calories, foodGroup);  // Add the ingredient to the recipe
        }

        static string GetFoodGroupSelection()
        {
            switch (Console.ReadLine())
            {
                case "1": return "Vegetables and fruits";
                case "2": return "Starchy foods";
                case "3": return "Proteins";
                case "4": return "Dairy";
                case "5": return "Fats and sugars";
                default: return "Unknown";
            }
        }

        static void AddStepsToRecipe(RecipeManager recipeManager)
        {
            Console.Write("Enter the name of the recipe: ");
            string recipeName = Console.ReadLine();
            Recipe recipe = recipeManager.GetRecipeByName(recipeName);  // Get the recipe by name
            if (recipe == null)
            {
                Console.WriteLine("Recipe not found.");
                return;  // Recipe not found, return
            }
            Console.Write("Enter the step description: ");
            string stepDescription = Console.ReadLine();
            recipe.Steps.Add(new Step { Description = stepDescription });  // Add the step to the recipe
            Console.WriteLine("Step added successfully.");
        }

        static void ScaleRecipe(RecipeManager recipeManager)
        {
            Console.Write("Enter the name of the recipe: ");
            string recipeName = Console.ReadLine();
            Recipe recipe = recipeManager.GetRecipeByName(recipeName);  // Get the recipe by name
            if (recipe == null)
            {
                Console.WriteLine("Recipe not found.");
                return;  // Recipe not found, return
            }
            Console.Write("Enter the scaling factor (e.g., 2 for double, 0.5 for half): ");
            if (!double.TryParse(Console.ReadLine(), out double factor))  // Parse the scaling factor as double
            {
                Console.WriteLine("Invalid scaling factor. Please try again.");
                return;  // Invalid input, return
            }
            recipe.ScaleRecipe(factor);  // Scale the recipe
            Console.WriteLine("Recipe scaled successfully.");
        }

        static void ResetRecipe(RecipeManager recipeManager)
        {
            Console.Write("Enter the name of the recipe: ");
            string recipeName = Console.ReadLine();
            Recipe recipe = recipeManager.GetRecipeByName(recipeName);  // Get the recipe by name
            if (recipe == null)
            {
                Console.WriteLine("Recipe not found.");
                return;  // Recipe not found, return
            }
            recipe.ResetRecipe();  // Reset the recipe
            Console.WriteLine("Recipe reset to original values.");
        }

        static void RecipeExceedsCaloriesHandler(Recipe recipe)
        {
            string message = $"Warning: {recipe.Name} exceeds 300 calories!";
            if (recipe.TotalCalories < 200)
            {
                message += " This recipe is low in calories, suitable for a snack.";
            }
            else if (recipe.TotalCalories >= 200 && recipe.TotalCalories <= 500)
            {
                message += " This recipe has moderate calories, suitable for a balanced meal.";
            }
            else
            {
                message += " This recipe is high in calories and should be consumed sparingly.";
            }
            Console.WriteLine(message);
        }
    }
}
//------------------------------------------...ooo000 END OF FILE 000ooo...------------------------------------------------------//