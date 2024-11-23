using System.Collections;

//IEnumerable and IEnumerator class implementation

string[] academyNames = { "Alice", "Bob", "Charlie" };
Academy academy = new Academy(academyNames.ToList());
foreach (var student in academy)
{
    Console.WriteLine(student);
}

class Academy : IEnumerator, IEnumerable
{
    private readonly List<string> Names;
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