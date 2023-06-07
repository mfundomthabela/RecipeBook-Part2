Recipe Management Application
This is a recipe management application that allows users to input recipes and calculate their total calories.
The application provides features to display items, calculate total calories, and display recipes alphabetically.

Features
Display Items
The RecipesID method allows the user to enter a list of items and displays them on the console.

Calculate Total Calories
The TotalCalories method calculates the total number of calories in a recipe based on the number of servings and the entered calories. 
If the total calories exceed 300, it notifies the user that they have exceeded the calorie limit.
Display Recipes Alphabetically
The DisplayAlphabetically method displays the recipes in alphabetical order. 
It prompts the user to choose between returning to the menu or exiting the application.

Stack Overflow. (n.d.). Sort a list alphabetically. [online] 
Available at: https://stackoverflow.com/questions/6965337/sort-a-list-alphabetically [Accessed 26 May 2023].‌

Usage
Run the application.
Choose the desired option from the menu.
Follow the prompts to input items, calculate total calories, or display recipes alphabetically.
Follow the on-screen instructions to navigate through the application.

Development
The application is written in C# and utilizes delegates and event handling. 
The calories class represents a recipe item with a name and calorie count.
The NotificationManager class handles the notification of exceeded calories.
The DisplayItemDelegate delegate is used to display items, and the CalculateTotalCaloriesDelegate delegate is used to calculate total calories.

Contributing
Contributions to this recipe management application are welcome.
If you find any issues or have suggestions for improvement, please submit a pull request or open an issue.

ChangeLog
I added a generic list of RecipeBook, Steps and Ingredients to store all user input data.
I added additional classes so that my code is not in one class.
In part 1 my code did not print all things that were looped, 
I added more comments to the code.
