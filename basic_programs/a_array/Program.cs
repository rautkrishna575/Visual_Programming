namespace a_array;

class Program
{
    static void Main(string[] args)
    {
        int[] num = {102,12,13,41,55,43,55};
        Console.WriteLine("The array before sorting are:");
        foreach (int n in num)
        {
            Console.WriteLine(n);
        }

        Array.Sort(num);
        Array.Reverse(num);
        Console.WriteLine("The array after sorting are:");
        foreach (int n in num)
        {
            Console.WriteLine(n);
        }
    }
}
