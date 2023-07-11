//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Input your digit of the day of the week");
int dDay = Convert.ToInt32(Console.ReadLine());
if (dDay > 0 && dDay <8)
{
 if (dDay>=6)
  Console.WriteLine("It's a weekend!");
 else
 Console.WriteLine("It's a weekday...");
}
else Console.WriteLine("Oops, this digit cannot be the day of the week. Ty again."); 