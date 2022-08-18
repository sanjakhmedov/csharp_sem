// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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

int InRangeCount (int[] arr, int min, int max)
{
    int cuonter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (min < arr[i] && max > arr[i])
        {
            cuonter++;
        }
    }
    return cuonter;
}

int[] array = CreateArrayRndInt(123, -100, 100);
PrintArray(array);
Console.WriteLine();
int count = InRangeCount(array, 10, 99);
Console.WriteLine($"Amount of numbers in range from 10 to 99 is equal to = {count}!");