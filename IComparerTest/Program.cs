using System.Collections;

var animalList = new AnimalList();
animalList.AddAnimal(new Cat("Bella", 5));
animalList.AddAnimal(new Cat("Luna", 6));
animalList.AddAnimal(new Cat("Max", 10));
animalList.AddAnimal(new Cat("Barsik", 0));
animalList.AddAnimal(new Cat("Mark", 11));

animalList.DisplayAnimals();

Console.WriteLine("********************");

animalList.Sort();
animalList.DisplayAnimals();







public class Cat(string name, byte age) : IComparable<Cat>
{
    public string Name { get; set; } = name;
    public byte Age { get; set; } = age;

    public int CompareTo(Cat? other)
    {
        return Age.CompareTo(other.Age);
    }
}

public interface IAnimal
{
    string Name { get; set; }
    byte Age { get; set; }
}

public class AnimalList : IEnumerable<Cat>
{
    private int _count = 0;
    private int _capacity = 4;
    private Cat[] _animals = new Cat[4];

    public void AddAnimal(Cat cat)
    {
        if (_count == _capacity)
        {
            _capacity *= 2;
            Array.Resize(ref _animals, _capacity);
        }
        _animals[_count++] = cat;
    }

    public void Sort()
    {
        Array.Sort(_animals, 0, _count);
    }

    public void DisplayAnimals()
    {
        for (var i = 0; i < _count; i++)
            Console.WriteLine($"Cat: {_animals[i].Name}");
    }

    public IEnumerator<Cat> GetEnumerator()
    {
        for (int i = 0; i < _count; i++) yield return _animals[i];
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}