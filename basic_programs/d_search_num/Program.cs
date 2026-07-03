namespace d_search_num;

class Program
{
    static void Main(string[] args)
    {
        int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("Enter the number to search: ");
        int searchNum = int.Parse(Console.ReadLine());
        bool found = false;

        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] == searchNum)
            {
                found = true;
                break;
            }
        }
        if (found)
        {
            Console.WriteLine("Number found in the array.");
        }
        else
        {
            Console.WriteLine("Number not found in the array.");
        }
    }
}
