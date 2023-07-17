// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.

int SumOfNumbers(int Number)
{
    int Sum = 0;
    while (Number > 0)
    {
        Sum = Sum + Number % 10;
        Number = Number / 10;
    }
    return Sum;
}

Console.WriteLine("Input your Number");
int Number = Convert.ToInt32(Console.ReadLine());
int Sum = SumOfNumbers(Number);
Console.WriteLine($"The sum of digits of your Number is {Sum}");