// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

bool CheckNum(int[] arr, int num)
{
    bool ret = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
        {
            ret = true;
            break;
        }
    }
    return ret;
}

int[] array = CreateArrayRndInt(10, -20, 20);
PrintArray(array);
Console.WriteLine();
bool checkNum = CheckNum(array, 7);
Console.WriteLine(checkNum);
