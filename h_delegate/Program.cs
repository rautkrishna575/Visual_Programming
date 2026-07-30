namespace h_delegate;

public delegate void MyDelegate(string message); // Delegate is a type that represents references to methods with a specific parameter list and return type.
class Program
{
    public static void displayName(string name) // Method that matches the delegate signature.
    {
        Console.WriteLine("Name: " + name);
    }
    static void Main(string[] args)
    {
        MyDelegate del = new MyDelegate(displayName); // Create an instance of the delegate and assign it a method.
        del("Alice"); // Invoke the delegate, which calls the assigned method.
    }
}
