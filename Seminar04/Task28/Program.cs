// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Enter the integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int Factorial(int n)
{
    int res = 1;
    for (int i = 1; i < n; i++)
    {
        res = res + res*i;
    }
    return res;
}

int sum = Factorial(num);
Console.WriteLine(sum);