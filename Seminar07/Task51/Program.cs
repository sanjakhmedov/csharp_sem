// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matr = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = rnd.Next(min, max + 1);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 4}, ");
            else Console.Write($"{matrix[i,j], 4}");
        }
        Console.WriteLine("]");
    }
    Console.WriteLine();
}

int MatrDiagonalSum(int[,] matr)
{
    int sumOfDiagonal = 0;
    for (int i = 0; i < matr.GetLength(0) || i < matr.GetLength(1); i++)
    {
        sumOfDiagonal += matr[i,i];
    }
    return sumOfDiagonal;
}

int[,] matrix = CreateMatrixRndInt(5, 5, 1, 9);
PrintMatrix(matrix);
int matrDiagonalSum = MatrDiagonalSum(matrix);
Console.WriteLine("Matrix diagonal sum equals " + matrDiagonalSum);

