namespace oops;

class Student
{
    public void display()
    {
        Console.WriteLine("Hello Student!");
    }
    static void Main(string[] args)
    {
        Student s = new Student();
        s.display();
    }
}
