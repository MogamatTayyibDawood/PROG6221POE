using System;
using System.Collections.Generic;

namespace PROG6221POE
{
    public class Recipe
    {
        public string Name { get; set; }  // Property for the recipe name
        public List<Ingredient> Ingredients { get; set; }  // List to store ingredients
        public List<Step> Steps { get; set; }  // List to store steps
        public double TotalCalories { get; set; }  // Property for total calories

        public Recipe(string name)
        {
            Name = name;  // Initialize the recipe name
            Ingredients = new List<Ingredient>();  // Initialize the ingredients list
            Steps = new List<Step>();  // Initialize the steps list
        }

        public void AddIngredient(string name, double quantity, string unit, double calories, string foodGroup)
        {
            Ingredients.Add(new Ingredient(name, quantity, unit, calories, foodGroup));  // Add a new ingredient to the list
        }

        public void CalculateTotalCalories()
        {
            TotalCalories = 0;  // Reset total calories
            foreach (var ingredient in Ingredients)
            {
                TotalCalories += ingredient.Calories * ingredient.Quantity;  // Calculate total calories.
            }
        }

        public void ScaleRecipe(double factor)
        {
            foreach (var ingredient in Ingredients)
            {
                ingredient.Quantity *= factor;  // Scale the quantity of each ingredient
            }
        }

        public void ResetRecipe()
        {
            foreach (var ingredient in Ingredients)
            {
                ingredient.ResetQuantity();  // Reset the quantity of each ingredient to the original value.
            }
        }
    }
}
//------------------------------------------...ooo000 END OF FILE 000ooo...-------------------------------------------------------//