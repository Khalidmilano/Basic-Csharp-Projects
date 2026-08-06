using System;

// Create a class
class MathClass
{
    // This method takes two integers as parameters.
    public void DoMath(int firstNumber, int secondNumber)
    {
        // Perform a math operation on the first integer.
        int result = firstNumber * 2;

        // Display the result.
        Console.WriteLine("Result: " + result);

        // Display the second integer.
        Console.WriteLine("Second Number: " + secondNumber);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instantiate the class.
        MathClass math = new MathClass();

        // Call the method by passing two numbers.
        math.DoMath(5, 10);

        // Call the method using named parameters.
        math.DoMath(firstNumber: 8, secondNumber: 20);

        // Keep the console window open.
        Console.ReadLine();
    }
}