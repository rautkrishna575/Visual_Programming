namespace VolumeofCube;

class Program
{
    int length;

    public void SetLength()
    {
        Console.WriteLine("Enter the length of the cube:");
        length = Convert.ToInt32(Console.ReadLine());
    }
    public void CalculateVolume()
    {
        int volume = length * length * length;
        Console.WriteLine("The volume of the cube is: " + volume);
    }
    static void Main(string[] args)
    {
        Program program = new Program();
        program.SetLength();
        program.CalculateVolume();
    }
}
