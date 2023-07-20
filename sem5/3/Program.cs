//Задача 38: Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.

double[] RandomArray()
{
    int size = new Random().Next(7, 15);
    double[] randomArray = new double[size];
    for (int i = 0; i < size; i++)
    {
        randomArray[i] = new Random().Next(-100, 100) + new Random().NextDouble();
    }
    return randomArray;
}
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]:f3}  ");
    }
    Console.WriteLine();
}

double FindMax(double[] array)
{
    int i = 0;
    double max = array[i];
    for (i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double FindMin(double[] array)
{
    int i = 0;
    double min = array[i];
    for (i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}
double FindSubMinMax(double[] array, double max, double min)
{
    double subMinMax = max - min;
    Console.WriteLine($"The difference between Max: {max:f3} and Min: {min:f3} is {subMinMax:f3}");
    return subMinMax;
}
double[] arrayRand = RandomArray();
PrintArray(arrayRand);
double max = FindMax(arrayRand);
double min = FindMin(arrayRand);
double subMinMax = FindSubMinMax(arrayRand, max, min);