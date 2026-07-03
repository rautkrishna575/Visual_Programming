namespace c_string_sort;

class Program
{
    static void Main(string[] args)
    {
        string[] strings = { "banana", "apple", "cherry", "mango", "grape", "kiwi" };
            Console.WriteLine("The array before sorting are:");
        foreach (string s in strings)
        {
            Console.WriteLine(s);
        }
        Array.Sort(strings);
        Array.Reverse(strings);
        Console.WriteLine("The array after sorting are:");
        foreach (string s in strings)
        {
            Console.WriteLine(s);
        }
    }
}
