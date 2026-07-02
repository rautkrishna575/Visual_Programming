namespace AreaofCirle;

class Program
{
    double PI = 3.14;
    double radius;

    public void GetRadius()
    {
        Console.WriteLine("Enter the radius of the circle:");
        radius = Convert.ToDouble(Console.ReadLine());
    }

    public void CalculateArea()
    {
        double area = PI * radius * radius;
        Console.WriteLine("The area of the circle is: " + area);
    }

    static void Main(string[] args)
    {
        Program program = new Program();
        program.GetRadius();
        program.CalculateArea();
    }
}
