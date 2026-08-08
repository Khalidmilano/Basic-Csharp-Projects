using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an Employee object using the IQuittable interface type.
        IQuittable employee = new Employee
        {
            FirstName = "Khalid",
            LastName = "Omar"
        };

        // Call the Quit method using polymorphism.
        employee.Quit();

        // Keep the console open until a key is pressed.
        Console.ReadKey();
    }
}