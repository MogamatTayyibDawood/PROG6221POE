using System;
using System.Collections.Generic;

namespace PROG6221POE
{
    public class Recipe
    {
        public string Name { get; set; } //property to store the name of the recipe.
        public List<Ingredient> Ingredients { get; set; } //List to store the ingredients of the recipe
        public List<Step> Steps { get; set; } //List to store the steps of the recipe
        public double TotalCalories { get; set; } //property to store total calories of the recipe

        public Recipe(string name)
        {
            Name = name;
            Ingredients = new List<Ingredient>();
            Steps = new List<Step>();
        }

        public void AddIngredient(string name, double quantity, string unit, double calories, string foodGroup)
        {
            Ingredients.Add(new Ingredient { Name = name, Quantity = quantity, Unit = unit, Calories = calories, FoodGroup = foodGroup });
        }

        public void CalculateTotalCalories() //method to calculate the tota; calories of recipe
        {
            double total = 0; // variable to stpre the total calories
            foreach (var ingredient in Ingredients) //loop to go through each ingredient in recipe
            {
                total += ingredient.Calories * ingredient.Quantity; //adding calories of each ingredient to the total
            }
            TotalCalories = total; //Assigning the total calories to the TotalCalories property
        }
    }

}
//------------------------------------------...ooo000 END OF FILE 000ooo...------------------------------------------------------//