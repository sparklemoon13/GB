//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//что третьей цифры нет.

Console.WriteLine("Input your number");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 100)
{
   int var = number;
   while (var>1000)
   {
      var = number/10;
      number = number/10;
   }
    int dig = var % 10;
    Console.WriteLine(dig);
}
else Console.WriteLine("The number doesn't have the third digit."); 