namespace oopsParameterized;

class Program
{
    int roll;
    string? name;
    public void input(int r, string n)
    {
        roll = r;
        name = n;
    }
    public void display()
    {
        Console.WriteLine("Roll: " + roll);
        Console.WriteLine("Name: " + name);
    }
    static void Main(string[] args)
    {
        Program p = new Program();
        Program p1 = new Program();
        p.input(13, "John Chamling");
        p1.input(14, "Jane Smith");
        p.display();
        p1.display();
    }
}
