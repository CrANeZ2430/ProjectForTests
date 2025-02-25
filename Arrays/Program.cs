﻿//One dimensional

int[] myArray = { 47, 25, 91, 156, 32 };

int newArrayLength = 0;
foreach (int member in myArray)
{
    if (member % 2 == 0)
    {
        newArrayLength++;
    }
}

int[] newArray = new int[newArrayLength];
int i = 0;
foreach (int member in myArray)
{
    if (member % 2 == 0)
    {
        newArray[i] = member;
        i++;
    }
}

Console.WriteLine(newArrayLength);
Console.WriteLine($"{newArray[0]} {newArray[1]}");

//Multidimensional

int[,] array = { { 1, 2 , 3, 4 }, { 5, 6, 7, 8 } };
int value1 = array[1, 0];
Console.WriteLine(value1);

//Jagged

int[][] array2 = { [1, 2, 3, 4], [ 5, 6, 7 ] };
int value2 = array[1, 2];
Console.WriteLine(value2);

//ref

int a = 10, b = 20;
Console.WriteLine(a);
Console.WriteLine(b);
// 10 20

AddValue(a);
AddValueWithRef(ref b);
Console.WriteLine(a);
Console.WriteLine(b);
// 10 30

void AddValue(int i)
{
    i += 10;
}

void AddValueWithRef(ref int i)
{
    i += 10;
}