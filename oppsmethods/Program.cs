namespace oopsmethods;

class Student
{
    int roll;
    string? name;

    public void input(){
        Console.WriteLine("Enter Roll: ");
        roll = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Name: ");
        name = Console.ReadLine();
    }
    public void display(){
        Console.WriteLine("Roll: " + roll);
        Console.WriteLine("Name: " + name);
    }
    static void Main(string[] args)
    {
        Student s = new Student();
        s.input();
        s.display();
    }
}
