namespace d_exception;

class MyException : Exception
{
    public MyException(string message) 
    {
        Console.WriteLine(message);
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyException obj = new MyException("This is user defined exception");
        try{
            throw obj;
        }
        catch (MyException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
