// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
//
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон

Console.Write("Enter the number ");
Console.Write("a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("c: ");
int c = Convert.ToInt32(Console.ReadLine());

bool TriangleSidesCheck(int a_m, int b_m, int c_m)
{
    if(a_m + b_m <= c_m || a_m + c_m <= b_m || b_m + c_m <= a_m)
        return false;
    else
        return true;
}

bool result = TriangleSidesCheck(a, b, c);
Console.WriteLine(result);