namespace n_lambda_expression;

delegate int MyDel(int a);

class Program
{
    static void Main(string[] args)
    {
        MyDel del = (a) => a * a; //lambda expression (return the a*a and pass the value of a to the delegate)
        int val = del(5);
        Console.WriteLine($"The result is {val}");
    }
}
