namespace b_min_max;

class Program
{
    static void Main(string[] args)
    {
        int[] array = {102,99,33,55,26,74,22,73};
        Console.WriteLine("The minimum value in the array is: " + array.Min());
        Console.WriteLine("The maximum value in the array is: " + array.Max()); 
        Console.WriteLine("Sum Value : " + array.Sum()); 
        Console.WriteLine("Average Value :" + array.Average());
    }
}
