# Mogamat Tayyib Dawood ST10132915 Prog6221 POE 

## Github link: https://github.com/MogamatTayyibDawood/PROG6221POE.git

# Recipe Management Application

## Introduction

This is a standalone command-line application developed in C# using Visual Studio that allows users to manage recipes. The application includes features for adding ingredients, adding steps, displaying recipes, scaling recipes, resetting recipes, and clearing recipes. It also includes functionality for tracking calorie content and food groups for each ingredient.

## Prerequisites

- Microsoft Visual Studio
- .NET Core 4.8

## Compiling and Running the Software

1. Clone the repository:
   - Open a command prompt and navigate to the directory where you want to clone the repository.
   - Run the command to clone the repository:
     ```
     git clone https://github.com/MogamatTayyibDawood/PROG6221POE.git
     ```

2. Open the project in Visual Studio:
   - Launch Visual Studio and open the solution file located in the directory.

3. Build the project:
   - In Visual Studio, go to the Build menu and select Build Solution.
   - Ensure that the build is successful without any errors.

4. Run the application:
   - In Visual Studio, go to the Debug menu and select Start Debugging, or press F5.
   - The application will start running in the console window.

## Using the Application

When the application starts, you will see the following menu options:

1. **Add Recipe**
   - Prompts the user to enter the name of a new recipe.

2. **Add Ingredients to Recipe**
   - Prompts the user to enter the name of the recipe, then the name, quantity, unit, calories, and food group for each ingredient to be added.

3. **Display Recipes**
   - Displays a list of all recipes in alphabetical order by name.

4. **Display Recipe**
   - Prompts the user to enter the name of a recipe and then displays the details of the selected recipe, including ingredients and steps.

5. **Exit**
   - Exits the application.

## Features

1. **Add Unlimited Recipes**: Users can add an unlimited number of recipes.
2. **Name Each Recipe**: Each recipe can be named.
3. **Display Recipes Alphabetically**: The software displays all recipes in alphabetical order by name.
4. **Select Recipe to Display**: Users can choose which recipe to display from the list.
5. **Ingredient Details**: For each ingredient, users can enter:
   - The number of calories.
   - The food group the ingredient belongs to.
6. **Total Calorie Calculation**: The software calculates and displays the total calories of all the ingredients in a recipe.
7. **Calorie Notification**: The software notifies the user when the total calories of a recipe exceed 300.

## Food Groups

According to the South African food-based dietary guidelines (SAFBDGs 2012), there are seven food groups that can be eaten regularly:

1. Starchy foods
2. Vegetables and fruits
3. Dry beans, peas, lentils, and soya
4. Chicken, fish, meat, and eggs
5. Milk and dairy products
6. Fats and oils
7. Water

For more information, visit [Sweet Life: What are the different food groups?](https://sweetlife.org.za/what-are-the-different-food-groups-a-simple-explanation/)

## Non-functional Requirements

1. **International Coding Standards**: The code follows internationally accepted coding standards. Comprehensive comments explain variable names, methods, and the logic of the programming code.
2. **Use of Classes**: The application uses classes to represent recipes, ingredients, and steps.
3. **Generic Collections**: Generic collections are used to store recipes, ingredients, and steps, instead of arrays.
4. **Delegate for Calorie Notification**: A delegate is used to notify the user when a recipe exceeds 300 calories.
5. **Unit Testing**: Unit tests are created to test the total calorie calculation.

## Unit Testing

The application includes unit tests to verify the accuracy of the total calorie calculation. These tests can be run to ensure the functionality works as expected.
