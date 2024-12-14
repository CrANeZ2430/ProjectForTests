MyStruct myStruct = new MyStruct(12, 156);
Console.WriteLine($"Age: {myStruct.Age} y.o., height: {myStruct.Height} sm");

public class School
{
    // an error
    //static MyStruct myStruct = new MyStruct();
}

public ref struct MyStruct(int age, int name)
{
    public int Age { get; set; } = age;
    public int Height { get; set; } = name;
}