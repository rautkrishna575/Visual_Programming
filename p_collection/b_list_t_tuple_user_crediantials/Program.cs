namespace b_list_t_tuple_user_crediantials;
#nullable disable
class Program
{
    static void Main(string[] args)
    {
        bool isFound = false;
//Tuple refers to a data structure that can hold a fixed number of elements of different types. In this case, we are using a List of Tuples to store username-password pairs. Each Tuple contains two elements: the first element is the username (string) and the second element is the password (string). The List allows us to store multiple such Tuples, enabling us to manage multiple user credentials in a single collection.
        List<Tuple<string, string>> Credentials = new List<Tuple<string, string>>{
            new Tuple<string, string>("ram", "ram123"),
            new Tuple<string, string>("shyam", "shyam123"),
            new Tuple<string, string>("hari", "hari123")
        };

        Console.WriteLine("Enter your username: ");
        string username = Console.ReadLine();
        Console.WriteLine("Enter your password: ");
        string password = Console.ReadLine();

        foreach(Tuple<string, string> credential in Credentials)
        {
            if(credential.Item1 == username && credential.Item2 == password) //Item1 and Item2 are properties of the Tuple class that allow us to access the first and second elements of the Tuple, respectively. In this case, Item1 corresponds to the username and Item2 corresponds to the password. The condition checks if both the username and password entered by the user match any of the username-password pairs stored in the Credentials list.
            {
                isFound = true;
                break;
            }
        }

        if(isFound)
        {
            Console.WriteLine("Welcome {0} ", username);
        }
        else
        {
            Console.WriteLine("Invalid username or password.");
        }
    }
}
