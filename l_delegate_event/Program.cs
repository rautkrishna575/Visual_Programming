namespace l_delegate_event;

public delegate string MyDel(string str);

class EventPro
{

    event MyDel MyEvent; //event is a special kind of delegate that is used to provide notifications.
    public EventPro()
    {
        this.MyEvent += new MyDel(this.DisplayMessage);
    }

    public string DisplayMessage(string str)
    {
        return "Hello "+ str;
    }
    static void Main(string[] args)
    {
        EventPro eventPro = new EventPro();

        string result = eventPro.MyEvent("Sanothimi Campus");
        Console.WriteLine(result);
    }
}
