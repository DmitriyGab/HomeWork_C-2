﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 > 99 && number1 < 1000)
{
    int x1 = number1 / 10;
    int x2 = x1 % 10;
    
    Console.WriteLine("Второе числое - " +x2);
}
else
{
    Console.WriteLine("Указанное число не является трехзначным");
}
