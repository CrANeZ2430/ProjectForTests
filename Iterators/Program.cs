Base x = new Base();
Derived y = new Derived();

x.Print();
y.Print();

class Base
{
    public void Print()
    {
        Console.WriteLine($"{GetType()} Print");
    }
}

class Derived : Base
{
    
}