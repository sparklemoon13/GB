// Задача 50. Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.

int[,] CreateArray()
{
    int rows = new Random().Next(4, 10);
    int collums = new Random().Next(4, 10);
    int[,] newArray = new int[rows, collums];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < collums; j++)
        {
            newArray[i, j] = new Random().Next(-100, 101);
        }
    }
    return newArray;
}

void Print2dArray(int[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindElementOfAaray2d(int[,] array)
{
    Console.WriteLine("Enter a row of searched element of the array:");
    int userRowI = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter a collum of searched element of the array:");
    int userCollumJ = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    if (userRowI < array.GetLength(0) && userCollumJ < array.GetLength(1))
    {
        Console.WriteLine($"The number is : {array[userRowI, userCollumJ]}");
    }
    else Console.WriteLine("The position doesn't exist in current array!");
}
int[,] newArray2d = CreateArray();
Print2dArray(newArray2d);
FindElementOfAaray2d(newArray2d);
