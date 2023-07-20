//Задача 36: Задайте одномерный массив, 
//заполненный случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях.

int[] RandomArray()
{
    int size = new Random().Next(7, 15);
    int[] randomArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        randomArray[i] = new Random().Next(-100, 100);
    }
    return randomArray;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int SumEvenIPosition(int[] randomAprray)
{
    int sum = 0;
    for (int i = 0; i < randomAprray.Length; i++)
    {
        if (i % 2 > 0)
        {
            sum = sum + randomAprray[i];
        }
    }
    Console.WriteLine($"The sum of even position elements of youe array is {sum}");
    return sum;
}
int[] arrayRand = RandomArray();
PrintArray(arrayRand);
int sumNum = SumEvenIPosition(arrayRand);