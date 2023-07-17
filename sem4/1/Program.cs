// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

double NumPower(double A, int B)
{
    double result = Math.Pow(A, B);
    Console.WriteLine("result");
    return result;
}
Console.WriteLine("Input your number A - base of the power");
double BaseOfPower = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input your number B - the power of number");
int PowerOfNumber = Convert.ToInt32(Console.ReadLine());
double result = NumPower(BaseOfPower, PowerOfNumber);
Console.WriteLine($"The result is {result:f3}");