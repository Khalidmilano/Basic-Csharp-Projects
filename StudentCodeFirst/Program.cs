using StudentCodeFirst;

using (var context = new SchoolContext())
{
    context.Database.EnsureCreated();

    Student student = new Student
    {
        StudentName = "John Smith"
    };

    context.Students.Add(student);
    context.SaveChanges();

    Console.WriteLine("Student database created successfully.");
    Console.WriteLine("Student added successfully.");
    Console.WriteLine($"Student ID: {student.StudentId}");
    Console.WriteLine($"Student Name: {student.StudentName}");
}