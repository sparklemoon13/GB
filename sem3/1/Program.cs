//Задача 19. напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

Console.WriteLine("Input your 5-digit number");
int number = Convert.ToInt32(Console.ReadLine());
void Palindrome (int number)
{
    int a = number/10000;
    int b = (number/1000)%10;
    int c = (number%100)/10;
    int d = number%10;
    if(a==d & b==c)
    Console.WriteLine("Yes, it's a palindrome");
    else Console.WriteLine("No, it's not a palindrome");
}
if (number >= 10000& number < 100000)
Palindrome (number);
else Console.WriteLine("Your number is not 5-digit");