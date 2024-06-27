using System;
using System.Collections.Generic;
using System.Linq;

namespace PROG6221POE
{
    public class RecipeManager
    {
        private List<Recipe> recipes;  // List to store recipes

        public RecipeManager()
        {
            recipes = new List<Recipe>();  // Initialize the recipes list
        }

        public delegate void RecipeExceedsCaloriesHandler(Recipe recipe);  // Delegate for the RecipeExceedsCalories event
        public event RecipeExceedsCaloriesHandler RecipeExceedsCalories;  // Event for when a recipe exceeds calories

        public void AddRecipe(string name)
        {
            recipes.Add(new Recipe(name));  // Add a new recipe to the list
        }

        public void AddIngredientToRecipe(string recipeName, string ingredientName, double quantity, string unit, double calories, string foodGroup)
        {
            Recipe recipe = recipes.Find(r => r.Name == recipeName);  // Find the recipe by name
            if (recipe != null)
            {
                recipe.AddIngredient(ingredientName, quantity, unit, calories, foodGroup);  // Add the ingredient to the recipe
                recipe.CalculateTotalCalories();  // Calculate the total calories
                if (recipe.TotalCalories > 300)
                {
                    RecipeExceedsCalories?.Invoke(recipe);  // Invoke the event if total calories exceed 300
                }
            }
            else
            {
                Console.WriteLine("Recipe not found.");  // Recipe not found
            }
        }

        public void DisplayRecipes()
        {
            var sortedRecipes = recipes.OrderBy(r => r.Name).ToList();  // Sort the recipes by name
            foreach (var recipe in sortedRecipes)
            {
                Console.WriteLine(recipe.Name);  // Display each recipe name
            }
        }

        public void DisplayRecipe(string name)
        {
            Recipe recipe = recipes.Find(r => r.Name == name);  // Find the recipe by name
            if (recipe != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;  // Set the console text color to green
                Console.WriteLine($"Recipe: {recipe.Name}");  // Display the recipe name
                Console.WriteLine("Ingredients:");
                foreach (var ingredient in recipe.Ingredients)
                {
                    Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name} ({ingredient.Calories} calories, {ingredient.FoodGroup})");  // Display each ingredient
                }
                Console.WriteLine("\nSteps:");
                foreach (var step in recipe.Steps)
                {
                    Console.WriteLine(step.Description);  // Display each step
                }
                Console.WriteLine($"Total Calories: {recipe.TotalCalories}");  // Display the total calories
                Console.ResetColor();  // Reset the console text color
            }
            else
            {
                Console.WriteLine("Recipe not found.");  // Recipe not found
            }
        }

        public void ClearData()
        {
            recipes.Clear();  // Clear the recipes list
        }

        public List<Recipe> GetRecipes()
        {
            return recipes;  // Return the list of recipes
        }

        public Recipe GetRecipeByName(string name)
        {
            return recipes.Find(r => r.Name == name);  // Find and return the recipe by name
        }
    }
}
//------------------------------------------...ooo000 END OF FILE 000ooo...-------------------------------------------------------//