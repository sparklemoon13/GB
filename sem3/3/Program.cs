//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Input number N"); 
int N = Convert.ToInt32(Console.ReadLine());
int CubesN (int N)
{
    int number = 1;
    int cube = 0;
    while (number<=N)
    {
    cube = number*number*number;
    number++;
    Console.Write($" {cube} ");
    }
    return cube;
    
}
if (N>0)
{
    int CubesNumbers = CubesN(N);
}
else
{
Console.WriteLine("Input number N > 0!"); 
}