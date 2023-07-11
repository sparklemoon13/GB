//Задача 10: Напишите программу, которая принимает 
//на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Input three-digit number");
int Num = Convert.ToInt32(Console.ReadLine());
if (Num >= 100 && Num <1000)
{
 int NumA = Num / 100;
 int NumB = (Num - NumA * 100) / 10;
 Console.WriteLine(NumB);
}
else
{
  Console.WriteLine("Your number is not three-digit."); 
}