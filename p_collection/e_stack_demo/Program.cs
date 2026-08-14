namespace e_stack_demo;
using System.Collections;
class Program
{
    static void Main(string[] args)
    {
        Stack stack = new Stack();
        stack.Push("Ram");
        stack.Push(10);
        stack.Push(10.452);
        stack.Push(true);
        Console.WriteLine("Stack Elements are: ");
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
        stack.Pop();
        //After Pop
        Console.WriteLine("Stack Elements after pop are: ");
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine($"Top element is: {stack.Peek()}");
        if(stack.Contains(10))
        {
            Console.WriteLine("Stack contains 10");
        }
        else
        {
            Console.WriteLine("Stack does not contain 10");
        }
    }
}
