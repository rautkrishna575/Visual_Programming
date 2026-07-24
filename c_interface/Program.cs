namespace c_interface;

interface IVehicle
{
    public void accelerate();
}

class Aeroplane : IVehicle
{
    public void accelerate()
    {
        Console.WriteLine("Aeroplane is accelerating");
    }
}
class Car : IVehicle
{
    public void accelerate()
    {
        Console.WriteLine("Car is accelerating");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Aeroplane obj = new Aeroplane();
        // Car obj1 = new Car();
        IVehicle obj = new Aeroplane();
        IVehicle obj1 = new Car();
        obj.accelerate();
        obj1.accelerate();
    }
}
