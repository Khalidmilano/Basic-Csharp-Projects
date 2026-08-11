using System;

// This class contains the main entry point of the program.
class Program
{
    // Main method starts the program.
    static void Main(string[] args)
    {
        // Create the first Employee object and assign values.
        Employee employee1 = new Employee();
        employee1.Id = 1;
        employee1.FirstName = "John";
        employee1.LastName = "Smith";

        // Create the second Employee object and assign values.
        Employee employee2 = new Employee();
        employee2.Id = 1;
        employee2.FirstName = "Jane";
        employee2.LastName = "Doe";

        // Compare the employees using the overloaded == operator.
        bool areEqual = employee1 == employee2;

        // Compare the employees using the overloaded != operator.
        bool areNotEqual = employee1 != employee2;

        // Display the results.
        Console.WriteLine("Are the employees equal? " + areEqual);
        Console.WriteLine("Are the employees different? " + areNotEqual);
    }
}