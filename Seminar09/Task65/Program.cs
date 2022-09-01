﻿// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


Console.WriteLine("Enter the intiger number: ");
Console.Write("M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("N: ");
int n = Convert.ToInt32(Console.ReadLine());

void NaturalNumber(int m, int n)
{
    if (m == n) 
    {
        Console.Write($"{m} "); 
        return;
    }
    if (m > n)
    {
        Console.Write($"{m} ");
        NaturalNumber(m - 1, n);
    }
    else 
    {
        NaturalNumber(m, n - 1);
        Console.Write($"{n} ");
    }
}

NaturalNumber(m, n);