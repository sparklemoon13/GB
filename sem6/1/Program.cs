// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] CreateArray(int size)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Input the number");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}
void PrintArray(int[] array)
{
    Console.Write("Okay, it's enough. Let us see what do we have");
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int CountPosNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"The count of positive numbers, you've entered is {count}");
    return count;
}

Console.WriteLine("Enter a number of elenents you want");
int size = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateArray(size);
PrintArray(newArray);
CountPosNumbers(newArray);