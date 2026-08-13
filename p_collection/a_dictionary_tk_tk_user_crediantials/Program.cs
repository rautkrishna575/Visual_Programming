namespace a_dictionary_tk_tk_user_crediantials;
#nullable disable
class Program
{
    static void Main(string[] args)
    {
        bool isFound = false;
        Dictionary<string, string> credentials = new Dictionary<string, string> //Dictionary refers to a collection of key-value pairs where each key is unique and maps to a specific value. In this case, the keys are usernames and the values are their corresponding passwords.
        {
            {"ram", "ram123"},
            {"shyam", "shyam123"},
            {"hari", "hari123"}
        };
        Console.WriteLine("Enter username: ");
        string username = Console.ReadLine();
        Console.WriteLine("Enter password: ");
        string password = Console.ReadLine();

        if(credentials.ContainsKey(username)){
            if(credentials[username] == password){
                isFound = true;
            }
        }

        if(isFound){
            Console.WriteLine("Welcome {0} ", username);
        }else{
            Console.WriteLine("Invalid username or password.");
        }

    }
}