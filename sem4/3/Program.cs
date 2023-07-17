//Задача 29: Напишите программу, которая задаёт массив 
//из 8 элементов и выводит их на экран.

int[] RandomArray(int lenght)
{
    int[] result = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        result[i] = new Random().Next(0,10);
    }
    return result;
}
void PrintArray(int[] arrayToPrint)
{
    Console.Write("[ ");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write(" ]");
}
int[] RandArray = RandomArray(8);
PrintArray(RandArray);