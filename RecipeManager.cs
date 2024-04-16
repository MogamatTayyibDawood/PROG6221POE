using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221POE
{
    class RecipeManager
    {
        // Declaring variables
        private List<Ingredient> ingredients;
        private List<Step> steps;
        private double scaleFactor = 1.0;

        public RecipeManager()
        {
            ingredients = new List<Ingredient>();
            steps = new List<Step>();
        }

        public void AddIngredient(string name, double quantity, string unit)
        {
            // new ingredient object added to ingredients list
            ingredients.Add(new Ingredient { Name = name, Quantity = quantity, Unit = unit });
        }

        public void AddStep(string description)
        {
            // new step object to steps list
            steps.Add(new Step { Description = description });
        }

        public void ScaleRecipe(double factor)
        {
            // checks if scale factor is valid = positive number
            if (factor <= 0)
            {
                Console.WriteLine("Invalid scale factor. The scale factor must be a positive number.");
                return;
            }

            // set scale factor, update ingredient quantities
            scaleFactor = factor;
            UpdateIngredientQuantities();
        }

        public void ResetRecipe()
        {
            // reset scale factor to 1.0, update ingredient quantities
            scaleFactor = 1.0;
            UpdateIngredientQuantities();
        }

        public void ClearRecipe()
        {
            // clear ingredients and steps list, reset scale factor to 1.0
            ingredients.Clear();
            steps.Clear();
            scaleFactor = 1.0;
        }

        private void UpdateIngredientQuantities()
        {
            // go through ingredients list, update quantities based on scale factor
            foreach (var ingredient in ingredients)
            {
                ingredient.Quantity *= scaleFactor;
            }
        }

        public void DisplayRecipe()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            
            // displays the ingredients, steps, and current scale factor
            Console.WriteLine("Ingredients:");
            foreach (var ingredient in ingredients)
            {
                Console.WriteLine($"{ingredient.Quantity:F2} {ingredient.Unit} of {ingredient.Name}");
            }
        
            Console.WriteLine("\nSteps:");
            for (int i = 0; i < steps.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i].Description}");
            }

            Console.WriteLine($"\nScale Factor: {scaleFactor}");

            Console.ResetColor();
        }

        public int GetIngredientCount()
        {
            // returns number of ingredients in recipe
            return ingredients.Count;
        }

        public int GetStepCount()
        {
            // returns number of steps in recipe
            return steps.Count;
        }
    } 
}
