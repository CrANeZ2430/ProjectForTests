//IEnumerator

using System.Collections;

int[] array = { 1, 2, 3, 4, 5 };
IEnumerator enumerator = array.GetEnumerator();

while (enumerator.MoveNext())
{
    Console.WriteLine(enumerator.Current);
    if ((int)enumerator.Current == 4)
    {
        Console.WriteLine("It is over");
        break;
    }
}
// 1 2 3 4 It is over

//IEnumerable class implementation

Car car = new Car();
foreach (string carName in car)
{
    Console.WriteLine(carName);
}

// A B C D E F

class Car : IEnumerable
{
    public string Brand { get; set; } = "Mercedes";
    
    public List<string> cars = new List<string>() { "A", "B", "C", "D", "E", "F" };


    public IEnumerator GetEnumerator()
    {
        return cars.GetEnumerator();
    }
}