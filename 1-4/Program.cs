﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите целое положительное число");
int num = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i <= num)
{
    System.Console.Write($"{i} ");
    i = i + 2;
}
System.Console.WriteLine("");