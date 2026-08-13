namespace c_sorted_list_tk_tv;
#nullable disable
class Program
{
    static void Main(string[] args)
    {
        SortedList<int, string> rollnames = new SortedList<int, string>(); //SortedList is a collection of key-value pairs that are sorted by the keys. In this case, the keys are roll numbers and the values are their corresponding names. 
        rollnames.Add(5, "Gita");
        rollnames.Add(31, "Hari");
        rollnames.Add(15, "Ram");
        rollnames.Add(4, "Sita");
        // rollnames.Add(2, "Heena"); //The above line is commented out because it would throw an exception if executed. This is because the key 2 already exists in the SortedList, and adding a duplicate key is not allowed. The SortedList requires that each key be unique, so attempting to add a duplicate key would result in an ArgumentException being thrown.
        rollnames.Add(2, "Shyam");
        rollnames.Add(7, "Mita");
        rollnames.Add(63, null); //The value for the key 63 is set to null, which means that there is no name associated with that roll number. This is allowed in a SortedList, as long as the key is unique.
        rollnames[63] = "Rita"; //The value for the key 63 is updated to "Rita", which means that the name associated with that roll number is now "Rita". This is done using the indexer property of the SortedList, which allows us to access and modify the value associated with a specific key.
        rollnames[4]= "Harry";
        foreach (var item in rollnames){
            Console.WriteLine("Roll No: {0} \n Name: {1}", item.Key, item.Value); //item.Key and item.Value are properties of the KeyValuePair class that allow us to access the key and value of each key-value pair in the SortedList, respectively. In this case, item.Key corresponds to the roll number and item.Value corresponds to the name. The line prints out the roll number and name for each entry in the SortedList.
        }
    }
}
