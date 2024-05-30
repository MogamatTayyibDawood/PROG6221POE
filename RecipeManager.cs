using System;
using System.Collections.Generic;
using System.Linq;

namespace PROG6221POE
{
    public class RecipeManager
    {
        public List<Recipe> recipes = new List<Recipe>();

        
        public delegate void RecipeExceedsCaloriesHandler(Recipe recipe); // Delegate to notify when recipe exceeds 300 calories

        
        public event RecipeExceedsCaloriesHandler RecipeExceedsCalories; // Event to subscribe to when a recipe exceeds 300 calories

        
        public void AddRecipe(string name) // Method to add a recipe.
        {
            recipes.Add(new Recipe(name));
        }

        
        public void AddIngredientToRecipe(string recipeName, string ingredientName, double quantity, string unit, double calories, string foodGroup) // Method to add an ingredient to a recipe
        {
            Recipe recipe = recipes.Find(r => r.Name == recipeName); //find recipe by name
            if (recipe != null) //if recipe is found
            {
                recipe.AddIngredient(ingredientName, quantity, unit, calories, foodGroup);
                recipe.CalculateTotalCalories(); //calculate total calories of the recipe.
                if (recipe.TotalCalories > 300) //if total calories exceed 300
                {
                    
                    RecipeExceedsCalories?.Invoke(recipe); // Notify if recipe exceeds 300 calories.
                }
            }
            else //if recipe not found
            {
                Console.WriteLine("Recipe not found."); //displaying a message for when not found
            }
        }

        
        public void DisplayRecipes() // Method to display all recipes in alphabetical order.
        {
            var sortedRecipes = recipes.OrderBy(r => r.Name).ToList(); //sorting recipes by name
            foreach (var recipe in sortedRecipes)
            {
                Console.WriteLine(recipe.Name); //displaying name of recipe
            }
        }

        
        public void DisplayRecipe(string name) // Method to display a recipe
        {
            Recipe recipe = recipes.Find(r => r.Name == name);
            if (recipe != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Recipe: {recipe.Name}");

                
                Console.WriteLine("Ingredients:"); // Display ingredients
                foreach (var ingredient in recipe.Ingredients)
                {
                    Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name} ({ingredient.Calories} calories, {ingredient.FoodGroup})");
                }

                
                Console.WriteLine("\nSteps:"); // Display steps
                foreach (var step in recipe.Steps)
                {
                    Console.WriteLine(step.Description);
                }

                Console.WriteLine($"Total Calories: {recipe.TotalCalories}");

                Console.ResetColor();
            }
            else //if recipe is not found
            {
                Console.WriteLine("Recipe not found."); //displaying message
            }
        }

        
        public List<Recipe> GetRecipes() //method to get all recipes
        {
            return recipes;
        }

        public Recipe GetRecipeByName(string name) //method to get recipe by name
        {
            return recipes.Find(r => r.Name == name);
        }

        public List<Recipe> GetSortedRecipes() //method to get all recipes by name
        {
            return recipes.OrderBy(r => r.Name).ToList();
        }
    }
}
//------------------------------------------...ooo000 END OF FILE 000ooo...-------------------------------------------------------//