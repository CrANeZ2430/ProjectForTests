// IEnumerable test

using System.Collections;

IEnumerable<int> numbers = Enumerable.Range(1, 10);
// foreach (int number in numbers)
// {
//     Console.WriteLine(number);
// }
// 1 2 3 4 5 6 7 8 9 10

IEnumerable<int> newArray = numbers.OrderBy(x => Random.Shared.Next());
//It is just a query
List<int> newList = numbers.OrderBy(x => Random.Shared.Next()).ToList();
//It is a list

foreach (int number in newArray)
{
    Console.WriteLine(number);
}
foreach (int number in newList)
{
    Console.WriteLine(number);
}
Console.WriteLine();
// a set of random numbers

//yield return
IEnumerable GetNumbers()
{
    for (int i = 0; i < 10; i++)
    {
        yield return Random.Shared.Next(1, 101);
    }
}

foreach (var number in GetNumbers())
{
    Console.WriteLine(number);
}

//IEnumerable and IEnumerator class implementation

string[] academyNames = { "Alice", "Bob", "Charlie" };
Academy academy = new Academy(academyNames.ToList());
foreach (var student in academy)
{
    Console.WriteLine(student);
}

class Academy : IEnumerator, IEnumerable
{
    public readonly List<string> Names;
    private int _index = -1;

    //IEnumerable
    public Academy(List<string> names)
    {
        Names = names;
    }
    
    public bool MoveNext()
    {
        _index++;
        return _index < Names.Count;
    }

    public void Reset()
    {
        _index = -1;
    }

    public object? Current => Names[_index];
    
    //IEnumerator
    public IEnumerator GetEnumerator()
    {
        return Names.GetEnumerator();
    }
}