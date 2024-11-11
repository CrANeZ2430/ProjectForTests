class Events
{
    //public delegate void EventDelegate(object sender, EventArgs e);
    //public EventDelegate OnHappenedWithSomeone;

    //action event
    //public event Action<string> Event;

    public event EventHandler<OnHappenedArgs>? OnHappened;

    public class OnHappenedArgs : EventArgs
    {
        public readonly int argsNum;

        public OnHappenedArgs(int constructorNum)
        {
            argsNum = constructorNum;
        }
    }

    private readonly int NumVariable = 10;

    public void Method()
    {
        //Event += EventMethod;
        OnHappened += GeneralOnHappened;

        //Event?.Invoke("Hello World!");
        OnHappened?.Invoke(this, new OnHappenedArgs(NumVariable) /* { var = var } */);
    }

    private void GeneralOnHappened(object? sender, OnHappenedArgs e)
    {
        Console.WriteLine("Your variable is " + e.argsNum);
    }

    /*private void EventMethod(string obj)
    {
        Console.WriteLine(obj);
    }*/
}