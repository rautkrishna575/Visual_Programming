namespace b_overriding;

class Dad {
    // public virtual void hi(){
    public void hi(){
        Console.WriteLine("Hi Child, I am your Dad");
    }
}

class Child : Dad {
    // public override void hi(){
    public new void hi(){
        Console.WriteLine("Hi Dad, I am your Child");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Dad obj = new Child();
        Child obj = new Child();
        obj.hi();
    }
}
