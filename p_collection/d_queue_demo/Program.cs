namespace s_queue_demo;
using System.Collections;
class Program
{
    static void Main(string[] args)
    {
        Queue queue = new Queue();
        queue.Enqueue("Ram");
        queue.Enqueue(10);
        queue.Enqueue(10.452);
        queue.Enqueue(true);

        Console.WriteLine("Queue Elements are: ");
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }
        queue.Dequeue();
        Console.WriteLine("Front element is: {0}", queue.Peek());

        if(queue.Contains(10))
        {
            Console.WriteLine("Queue contains 10");
        }
        else
        {
            Console.WriteLine("Queue does not contain 10");
        }
        //After Dequeue
        Console.WriteLine("Queue Elements are: ");
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }
    }
}
