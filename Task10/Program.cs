// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    System.Console.WriteLine(number / 10 % 10);
}
else 
{
    System.Console.WriteLine("Данное число не верно");
}
