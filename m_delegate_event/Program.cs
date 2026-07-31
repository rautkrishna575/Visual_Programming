namespace m_delegate_event;
#nullable disable
//step 1: Define a delegate
public delegate void TrafficLightChangeHandler(string color);

public class TrafficLight
{
    //step 2: Define an event based on the delegate
    public event TrafficLightChangeHandler OnColorChange;

    public void ChangeColor(string color)
    {
        //method that raises the event when the traffic light color changes
        Console.WriteLine($"Traffic light changed to {color}");
        //step 3: Raise the event
        OnColorChange?.Invoke(color); //Invoke the event, passing the new color as an argument
    }
}

public class Car
{
    public void ReactToLight(string color){
        if (color == "Red")
        {
            Console.WriteLine("Car stops.");
        }
        else if (color == "Green")
        {
            Console.WriteLine("Car goes.");
        }
        else if (color == "Yellow")
        {
            Console.WriteLine("Car slows down.");
        }
    }
}
class MainProgram
{
    static void Main(string[] args)
    {
        TrafficLight trafficLight = new TrafficLight();
        Car car = new Car();
        //step 4: Subscribe to the event
        trafficLight.OnColorChange += car.ReactToLight;
        //step 5: Change the traffic light color to trigger the event
        trafficLight.ChangeColor("Red");
        trafficLight.ChangeColor("Green");
        trafficLight.ChangeColor("Yellow");
    }
}
