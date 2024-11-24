using System.Collections;

int num1 = 1;
double num2 = 3.14;
string name = "Denis";

ArrayList newArrayList = new ArrayList();
newArrayList.Add(num1);
newArrayList.Add(num2);
newArrayList.Add(name);

foreach (object item in newArrayList)
{
    Console.WriteLine(item);
}

// 1 3.14 Denis