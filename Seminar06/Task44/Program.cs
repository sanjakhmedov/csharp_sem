// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Enter the number N: ");
int n = Convert.ToInt32(Console.ReadLine());

void PrintFibonacci(int num)
{
    int f1 = 0;
    int f2 = 1;
    int fn = f1 + f2;
    int i = 1;
    Console.Write(f1 + " ");
    while (i < num)
    {
        Console.Write(fn + " ");
        fn = f1 + f2;
        f1 = f2;
        f2 = fn;
        i++;
    }
}

PrintFibonacci(n);

// int[] f = PrintFibonacci(n);

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         if (i < array.Length - 1) Console.Write($"{array[i]}, ");
//     }
//     Console.Write(array[array.Length - 1]);
//     Console.WriteLine("]");
// }

// PrintArray(f);