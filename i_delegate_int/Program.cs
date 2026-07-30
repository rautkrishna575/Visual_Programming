namespace i_delegate_int;

public delegate void MyDelegate(int x);

class MyClass
{
    public static void square(int num) // Method that matches the delegate signature.
    {
        Console.WriteLine("Square: of {0} is {1}", num, num * num);
    }
    public static void Cube(int num) // Another method that matches the delegate signature.
    {
        Console.WriteLine("Cube: of {0} is {1}", num, num * num * num);
    }
}
class Program:MyClass
{
    static void Main(string[] args)
    {
        MyDelegate del = square; // Create an instance of the delegate and assign it a method.
        del(5); // Invoke the delegate, which calls the assigned method.
        MyDelegate del2 = Cube; // Create another instance of the delegate and assign it a different method.
        del2(3); // Invoke the second delegate, which calls the assigned method.
    }
}
