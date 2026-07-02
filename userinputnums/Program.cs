namespace userinputnums;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the value of a:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of b:");
        int b = Convert.ToInt32(Console.ReadLine());
        
        int sum = a + b;
        Console.WriteLine("The sum of a and b is: " + sum);
    }
}
