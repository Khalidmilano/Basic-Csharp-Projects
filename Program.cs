// Create the first Employee object and assign values to its properties.
Employee employee1 = new Employee();
employee1.Id = 1;
employee1.FirstName = "John";
employee1.LastName = "Smith";

// Create the second Employee object and assign values to its properties.
Employee employee2 = new Employee();
employee2.Id = 1;
employee2.FirstName = "Jane";
employee2.LastName = "Doe";

// Compare the two employees using the overloaded == operator.
bool areEqual = employee1 == employee2;

// Compare the two employees using the overloaded != operator.
bool areNotEqual = employee1 != employee2;

// Display the comparison results.
Console.WriteLine("Are the employees equal? " + areEqual);
Console.WriteLine("Are the employees different? " + areNotEqual);