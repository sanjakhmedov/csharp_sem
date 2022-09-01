// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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

int[,] SwapRowToCol(int[,] matr)
{
    int row = matr.GetLength(0);
    int col = matr.GetLength(1);
    int[,] newMatr = new int[row, col];
    if (row == col)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                newMatr[j, i] = matr[i, j];
            }
        }
    }
    else Console.WriteLine("Rows and Colums length are different!");
    return newMatr;
}

int[,] matrix = CreateMatrixRndInt(5, 5, 0, 10);
PrintMatrix(matrix);
int[,] resMatrix = SwapRowToCol(matrix);
Console.WriteLine();
PrintMatrix(resMatrix);