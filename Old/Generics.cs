class Generics
{
    public Character<int> warrior = new Character<int>(8);

    public void Print<T>(T data)
    {
        Console.WriteLine(data);
    }
}

class Character<T>
{
    private T Value;

    public Character(T value)
    {
        Value = value;
    }

    public void PrintValue()
    {
        Console.WriteLine(Value);
    }
}


/*class GenClass<T>()
{
    T value;

    public T1 TestMethod<T1>(T1 data)
    {
        return data;
    }
}*/