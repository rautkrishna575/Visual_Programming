namespace f_hash_table_demo;
using System.Collections;
class Program
{
    static void Main(string[] args)
    {
        Hashtable hashTable = new Hashtable(); //HashTable is a collection of key-value pairs where each key is unique. It allows for fast retrieval of values based on their associated keys.

        // hashTable.Add("Ram", "Ram, 25, Suryabinak"); // This line adds a key-value pair to the hash table. The key is "Ram" and the value is "Ram, 25, Suryabinak".
        hashTable.Add("Name", "Ram");
        hashTable.Add("Age", 25);
        hashTable.Add("Address", "Suryabinak");
        //hashTable.Add("Address", "Sindhupalchok"); // This will throw an exception because the key "Address" already exists in the hash table. Each key in a hash table must be unique.

        Console.WriteLine("Hash Table Elements are: ");
        foreach (DictionaryEntry entry in hashTable)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }
}
