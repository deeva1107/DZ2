﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите день недели");
int day = Convert.ToInt32(Console.ReadLine());
if (day >= 1 && day <= 7)

    if (day >= 6)
    {
        Console.WriteLine("Данный день является выходной");
    }
    else
    {
        Console.WriteLine("Данный день является рабочий");
    }

else

    Console.WriteLine("Не существует");

