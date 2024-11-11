using System.Collections;

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