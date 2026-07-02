namespace oopsDataMember;

class Student
{
    int roll;
    string? name;
    static void Main(string[] args)
    {
        Student s = new Student();
        Console.WriteLine("Enter Roll: ");
        s.roll = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Name: ");
        s.name = Console.ReadLine();
        Console.WriteLine("Roll: " + s.roll);
        Console.WriteLine("Name: " + s.name);
    }
}