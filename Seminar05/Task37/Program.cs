﻿// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}

int[] MultPairs(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length % 2 != 0) 
    {
        size++;
    }
    int[] multArr = new int[size];
    for (int i = 0; i < arr.Length / 2 ; i++)
    {
        if (arr[i] != arr[arr.Length / 2])
        {
            multArr[i] = arr[i] * arr[arr.Length - i - 1];
        }
    }
    if (arr.Length % 2 != 0) 
    {
        multArr[multArr.Length - 1] = arr[size];
    }
    return multArr;
}

int[] array = CreateArrayRndInt(5, -5, 5);
PrintArray(array);
Console.WriteLine();
int[] multPairs = MultPairs(array);
PrintArray(multPairs);