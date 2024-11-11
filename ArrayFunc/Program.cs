using System.Collections;

//IEnumerator

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

// IEnumerable test

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