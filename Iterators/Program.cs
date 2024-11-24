using System.Collections;

int[] newArray = { 1, 2, 3 };
List<int> newList = new() { 1, 2, 3 };

IEnumerable<int> newIEnumerable = newArray;
IEnumerator newIEnumerator = newArray.GetEnumerator();
IEnumerator<int> newEnumList = newList.GetEnumerator();

foreach (int item in newIEnumerable)
{
    Console.WriteLine(item);
}

