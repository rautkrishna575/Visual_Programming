namespace j_delegate_type;
public delegate int MyDelegate(int num); // Delegate is a type that represents references to methods with a specific parameter list and return type.
class Program
{
    public static int num=10;

    public static int addnum(int a){
        num+=a;
        return num;
    }

    public static int mulnum(int a){
        num*=a;
        return num;
    }

    public static int getnum(){
        return num;
    }

    static void Main(string[] args)
    {
        MyDelegate d1 = new MyDelegate(addnum); // Create an instance of the delegate and assign it a method.
        d1(25); // Invoke the delegate, which calls the assigned method.
        Console.WriteLine("Value of Add Num: {0}", getnum()); // Output the final value of num after the delegate invocations.
        MyDelegate d2 = new MyDelegate(mulnum); // Create another instance of the delegate and assign it a different method.
        d2(5); // Invoke the second delegate, which calls the assigned method.
        Console.WriteLine("Value of Mul Num: {0}", getnum()); // Output the final value of num after the delegate invocations.
    }
}
