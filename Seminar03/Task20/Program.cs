// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Enter coordinates for point A ");
Console.Write("x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter coordinates for point B ");
Console.Write("x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Pythagoras(int x1_m, int y1_m, int x2_m, int y2_m)
{
    return Math.Sqrt((x2_m - x1_m) * (x2_m - x1_m) + (y2_m - y1_m) * (y2_m - y1_m));
}

double result = Pythagoras(x1, y1, x2, y2);
Console.WriteLine($"Distance between point A ({x1},{y1}) and B ({x2},{y2}) = {Math.Round(result, 2)}");