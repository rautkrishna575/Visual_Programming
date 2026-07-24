namespace a_overloading;

class MyClass{
    public void displayDetails(int roll, string name)
    {
        Console.WriteLine("Roll: {0} and name = {1}", roll, name);
    }
    public void displayDetails( string name, int roll)
    {
        Console.WriteLine("Name: {0} and Roll = {1}",  name, roll);
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass obj = new MyClass();
        obj.displayDetails(1, "Alice");
        obj.displayDetails("Bob", 2);
    }
}
