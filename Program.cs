using System;

// Display welcome message
Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

// Ask the user for the package weight
Console.Write("Please enter the package weight: ");
double weight = Convert.ToDouble(Console.ReadLine());

// If the package weighs more than 50, display an error and stop the program
if (weight > 50)
{
    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
    return;
}

// Ask the user for the package width
Console.Write("Please enter the package width: ");
double width = Convert.ToDouble(Console.ReadLine());

// Ask the user for the package height
Console.Write("Please enter the package height: ");
double height = Convert.ToDouble(Console.ReadLine());

// Ask the user for the package length
Console.Write("Please enter the package length: ");
double length = Convert.ToDouble(Console.ReadLine());

// Check if the total dimensions are greater than 50
if ((width + height + length) > 50)
{
    Console.WriteLine("Package too big to be shipped via Package Express.");
    return;
}

// Calculate the shipping quote
double quote = (width * height * length * weight) / 100;

// Display the result as a dollar amount
Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
Console.WriteLine("Thank you.");