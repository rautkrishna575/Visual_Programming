namespace PerimeterofRectangle;

class Program
{
    int length;
    int breadth;
    public void GetData()
    {
        Console.WriteLine("Enter the length of the rectangle:");
        length = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the breadth of the rectangle:");
        breadth = Convert.ToInt32(Console.ReadLine());
    }
    public void CalculatePerimeter()
    {
        int perimeter = 2 * (length + breadth);
        Console.WriteLine("The perimeter of the rectangle is: " + perimeter);
    }
    static void Main(string[] args)
    {
        Program program = new Program();
        program.GetData();
        program.CalculatePerimeter();
    }
}
