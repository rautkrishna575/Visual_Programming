namespace o_lamda_expression;

delegate int MyDel(int a, int b);

class Program
{
    static void Main(string[] args)
    {
        MyDel del = (a,b) => (a>b)?a:b; //lambda expression 
        int val = del(10,20);
        Console.WriteLine($"The Larger value is {val}");
    }
}
