// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

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

void ChangeFirstToLastRow(int[,] matr)
{
    int tempF = 0;
    int tempL = 0;
    int row = matr.GetLength(0);
    int col = matr.GetLength(1);
    for (int i = 0; i < col; i++)
    {
        tempF = matr[0, i];
        tempL = matr[col - 1, i];
        matr[0, i] = tempL;
        matr[col - 1, i] = tempF;
    }
}

int[,] matrix = CreateMatrixRndInt(5, 5, 0, 10);
PrintMatrix(matrix);
ChangeFirstToLastRow(matrix);
Console.WriteLine();
PrintMatrix(matrix);