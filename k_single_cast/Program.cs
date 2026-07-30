namespace k_single_cast;

public class Program
{
    public delegate void mydelegate();

    class MyClass
    {
        public static void display()
        {
            Console.WriteLine("Hello Sanothimi");
        }

        public static void show()
        {
            Console.WriteLine("Hi Nepal");
        }

        public void print()
        {
            Console.WriteLine("Good Morning");
        }
    }

    static void Main(string[] args)
    {
        mydelegate obj = MyClass.display;
        obj();

        mydelegate obj1 = new mydelegate(MyClass.show);
        obj1();

        MyClass obj2 = new MyClass();
        mydelegate obj3 = obj2.print;
        obj3.Invoke();
    }
}
