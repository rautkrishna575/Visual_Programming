namespace SimpleIntrest;

class Program
{
    double principal;
    double rate;
    double time;
    public void input()
    {
        Console.WriteLine("Enter the principal amount:");
        principal = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the rate of interest:");
        rate = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the time in years:");
        time = Convert.ToDouble(Console.ReadLine());
    }

    public void calculateSimpleInterest()
    {
        double simpleInterest = (principal * rate * time) / 100;
        Console.WriteLine("The simple interest is: " + simpleInterest);
    }
    static void Main(string[] args)
    {
        Program program = new Program();
        program.input();
        program.calculateSimpleInterest();
    }
}
