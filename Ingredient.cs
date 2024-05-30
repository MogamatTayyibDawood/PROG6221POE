using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221POE
{
    public class Ingredient
    {
        public string Name { get; set; } // Defining a property called Name.
        public double Quantity { get; set; } // Defining a property called Quantity
        public string Unit { get; set; } //Defining a property called Unit
        public double Calories { get; set; } // Defining a property called Calories
        public string FoodGroup { get; set; } // Defining a property called FoodGroup

        private double originalQuantity; // Variable to store the original quantity.

        public Ingredient()
        {
            // Default constructor
        }

        public Ingredient(string name, double quantity, string unit, double calories, string foodGroup)
        {
            Name = name;
            Quantity = quantity;
            originalQuantity = quantity; // Store the original quantity
            Unit = unit;
            Calories = calories;
            FoodGroup = foodGroup;
        }

        // Method to reset the quantity of the ingredient back to its original value.
        public void ResetQuantity()
        {
            Quantity = originalQuantity; // Resetting the quantity to the original value.
        }
    }
}


//------------------------------------------...ooo000 END OF FILE 000ooo...------------------------------------------------------//