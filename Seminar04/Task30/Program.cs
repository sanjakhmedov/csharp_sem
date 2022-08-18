// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] arr = new int[8];
// for (int i = 0; i < arr.Length; i++)
// {
//     // Random random = new Random();
//     arr[i] = new Random().Next(0, 2);
// }

// for (int i = 0; i < arr.Length; i++)
// {
//     Console.Write(arr[i] + " ");
// }


int[] CreateArray(int l, int min, int max)
{
    int[] arr = new int[l];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}
int[] result = CreateArray(8, 0, 2);

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

PrintArray(result);