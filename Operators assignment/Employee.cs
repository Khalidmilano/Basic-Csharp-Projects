// This class represents an employee.
public class Employee
{
    // Stores the employee's ID number.
    public int Id { get; set; }

    // Stores the employee's first name.
    public string FirstName { get; set; } = "";

    // Stores the employee's last name.
    public string LastName { get; set; } = "";

    // Overloads the == operator to compare employees by their ID.
    public static bool operator ==(Employee employee1, Employee employee2)
    {
        return employee1.Id == employee2.Id;
    }

    // Overloads the != operator to compare employees by their ID.
    public static bool operator !=(Employee employee1, Employee employee2)
    {
        return employee1.Id != employee2.Id;
    }

    // Overrides Equals to support equality comparison.
    public override bool Equals(object? obj)
    {
        return obj is Employee employee && Id == employee.Id;
    }

    // Overrides GetHashCode to match the equality comparison.
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}