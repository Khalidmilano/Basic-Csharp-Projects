using System;

// The Employee class implements the IQuittable interface.
public class Employee : IQuittable
{
    // Stores the employee's first name.
    public string FirstName { get; set; }

    // Stores the employee's last name.
    public string LastName { get; set; }

    // This method is called when the employee quits.
    public void Quit()
    {
        Console.WriteLine(FirstName + " " + LastName + " has quit the job.");
    }
}