//Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.

//47
double[,] CreateArray()
{
    Console.WriteLine("Enter a number of rows for your array :");
    int rowsOfArray = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter a number of collums for your array :");
    int collsOfArray = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Minimum value of your array ? ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Maximum value of your array ? ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    double[,] newArray = new double[rowsOfArray, collsOfArray];
    for (int i = 0; i < rowsOfArray; i++)
    {
        for (int j = 0; j < collsOfArray; j++)
        {
            newArray[i, j] = Math.Round((new Random().Next(minValue, maxValue) + new Random().NextDouble()), 2);
        }
    }
    return newArray;
}

    void Print2dArray(double[,] array2d)
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
    double[,] newArray2d = CreateArray();
    Print2dArray(newArray2d);