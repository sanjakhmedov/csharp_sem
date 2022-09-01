// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matr = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(min, max);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matr.GetLength(1); j++)
        {

            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j],4}, ");
            else Console.Write($"{matr[i, j],4} ");

        }
        Console.WriteLine("]");
    }
}


void PrintArray(int[] arr)
{

    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i],2}, ");
        else Console.Write($"{arr[i],2} ");
    }
    Console.WriteLine("]");
}

int[] MatrixToArray(int[,] matr)
{
    int counter = 0;
    int[] arr = new int[matr.Length];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            arr[counter] = matr[i, j];
            counter++;
        }
    }
    return arr;
}

void FrequencyIndicator(int[] arr)
{
    Array.Sort(arr);
    PrintArray(arr);
    int count = 1;
    int num = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == num) count++;
        else
        {
            Console.WriteLine($"{num} --> {count}");
            num = arr[i];
            count = 1;
        }
        if (i == arr.Length - 1) Console.WriteLine($"{num} --> {count}");
    }
}


int[,] matrix = CreateMatrixRndInt(4, 4, 0, 9);
PrintMatrix(matrix);
int[] array = MatrixToArray(matrix);
Console.WriteLine();
PrintArray(array);
FrequencyIndicator(array);
