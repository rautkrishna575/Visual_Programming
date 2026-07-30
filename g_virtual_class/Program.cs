namespace g_virtual_class;

class Shape{
    protected int width, height; //protected can be accessed in derived class but cannot be accessed outside the class, object of the class cannot access protected members

    public Shape(int a = 0, int b = 0){ //constructor with default values
        width = a;
        height = b;
    }

    public virtual int area(){ //virtual method which can be overridden in derived class
        return 0;
    }
}

class Rectangle: Shape{ 
    public Rectangle(int a = 0, int b = 0): base(a, b){} //base keyword is used to call the constructor of base class

    public override int area(){ //overriding the virtual method of base class
        Console.WriteLine("Rectangle class area :");
        return width * height;  
    }
}

class Triangle: Shape{ 
    public Triangle(int a = 0, int b = 0): base(a, b){} //base keyword is used to call the constructor of base class

    public override int area(){ //overriding the virtual method of base class
        Console.WriteLine("Triangle class area :");
        return (width * height)/2;  
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape s; //creating object of base class
        Rectangle r = new Rectangle(10, 7); //creating object of derived class
        Triangle t = new Triangle(10, 5); //creating object of derived class

        s = r; //base class reference to derived class object
        Console.WriteLine(s.area()); //calling area method of derived class

        s = t; //base class reference to derived class object
        Console.WriteLine(s.area()); //calling area method of derived class
    }
}
