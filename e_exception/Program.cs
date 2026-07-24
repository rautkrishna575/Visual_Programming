namespace e_exception;

class InvalidVoter: Exception 
//User Defined Exception where we are inheriting the Exception class and creating our own exception class
{
    public InvalidVoter(string message) : base(message) {}
    
}
class Program
{

    static void getAge(int Age){
        if(Age<18){
            throw new InvalidVoter("You are not eligible to vote");
        }
        else{
            Console.WriteLine("You are eligible to vote");
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Your Age: ");
        int age = Convert.ToInt32(Console.ReadLine()); 
        try
        {
            getAge(age);
        }
        catch (InvalidVoter e)
        {
            Console.WriteLine(e);
        }
    }
}
