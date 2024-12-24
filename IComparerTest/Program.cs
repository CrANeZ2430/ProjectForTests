using System.Collections;

var animalList = new AnimalList<IAnimal>();
animalList.AddAnimal(new Cat("Bella", 5));
animalList.AddAnimal(new Cat("Luna", 6));
animalList.AddAnimal(new Dog("Max", 10));
animalList.AddAnimal(new Dog("Barsik", 0));
animalList.AddAnimal(new Cat("Mark", 11));

animalList.DisplayAnimals();

Console.WriteLine("********************");

animalList.Sort();
animalList.DisplayAnimals();







public class Cat(string name, byte age) : IAnimal
{
    public string Name { get; set; } = name;
    public byte Age { get; set; } = age;

    public int CompareTo(IAnimal? other)
    {
        return Age.CompareTo(other.Age);
    }
}

public class Dog(string name, byte age) : IAnimal
{
    public string Name { get; set; } = name;
    public byte Age { get; set; } = age;

    public int CompareTo(IAnimal? other)
    {
        return Age.CompareTo(other.Age);
    }
}

public interface IAnimal : IComparable<IAnimal>
{
    string Name { get; set; }
    byte Age { get; set; }
}

public class AnimalList<T> : IEnumerable<T> where T : IAnimal
{
    private int _count = 0;
    private int _capacity = 4;
    private T[] _animals = new T[4];

    public void AddAnimal(T animal)
    {
        if (_count == _capacity)
        {
            _capacity *= 2;
            Array.Resize(ref _animals, _capacity);
        }
        _animals[_count++] = animal;
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

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < _count; i++) yield return _animals[i];
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}