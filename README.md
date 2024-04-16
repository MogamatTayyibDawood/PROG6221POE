# Mogamat Tayyib Dawood ST10132915 Prog6221 POE part1

## Github link: https://github.com/MogamatTayyibDawood/PROG6221POE.git

# Recipe Management Application

## Introduction

This is a standalone command-line application developed in C# using Visual Studio that allows users to manage recipes, this icludes: adding ingredients, adding steps, displaying the recipe, scaling the recipe, resetting the recipe, and clearing the recipe.

## Prerequisites

- Microsoft Visual Studio 

- .NET Core 4.8

## Compiling and Running the Software

1. Clone the repository:

- Open a  command prompt and navigate to the directory where you want to clone the repository.

- Run the  command to clone the repository:

2. Open the project in Visual Studio:

- Launch Visual Studio and open the solution file located in the  directory.

3. Build the project:

- In Visual Studio, go to the Build menu and select Build Solution.

- Ensure that the build is successful without any errors.

4. Run the application:

- In Visual Studio, go to the Debug menu and select Start Debugging, this can also be done by pressing F5.

- The application will start running in the console window.

## Using the Application

When the application starts, you will see the following menu options:

1. Add ingredient

- Prompts the user to enter the name, quantity, and unit of an ingredient to be added to the recipe.
- Multiple ingredients can be added with their respective names, quantities and units.

2. Add step

- Prompts the user to enter a description for a step to be added to the recipe.
- Multiple steps can be added to describe the recipe.

3. Display Recipe

- Displays the current recipe, including the list of ingredients and the list of steps.

4. Scale Recipe

- Prompts the user to enter a scale factor (0.5, 2, 3, etc.), and then updates the quantities of all ingredients accordingly.

5. Reset Recipe

- Resets the scale factor to 1.0 and updates the ingredient quantities back to their original values.

6. Clear Recipe

- Clears all the ingredients and steps from the recipe.

7. Exit

- Exits the application.

You can navigate through the menu options by entering the corresponding number and pressing Enter. The application will handle invalid inputs and provide appropriate feedback to the user.

