//Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateArray()
{
    int rows = new Random().Next(5, 10);
    int collums = new Random().Next(5, 10);
    int[,] newArray = new int[rows, collums];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < collums; j++)
        {
            newArray[i, j] = new Random().Next(10, 100);
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
void FindAverageInCollums(int[,] array2d)
{

    for (int j = 0; j < array2d.GetLength(1); j++)
    {
        int i = 0;
        int sum = 0;
        double averCollum = 0;
        while (i < array2d.GetLength(0))
        {
            sum = sum + array2d[i, j];
            i++;
        }
        averCollum = Math.Round(Convert.ToDouble(sum) / array2d.GetLength(0), 2);
        Console.Write(averCollum + " | ");

    }

}


int[,] newArray = CreateArray();
Print2dArray(newArray);
FindAverageInCollums(newArray);