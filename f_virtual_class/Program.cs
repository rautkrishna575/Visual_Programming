namespace f_virtual_class;

class SuperClass{
    public virtual int calc(int a, int b){ //vitual method which can be overridden in derived class
        return a + b;
    }
}

class SubClass: SuperClass{ 
    public override int calc(int a, int b){ //overriding the virtual method of base class
        return a + b + 10;  
    }
} 

class Program
{
    static void Main(string[] args)
    {
        SubClass obj = new SubClass();
        Console.WriteLine("Redefined Result : " + obj.calc(5, 3));
    }
}
