// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Enter the integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
int NumCount(int num_m)
{
    int counter = 1;
    while (num_m >= 10)
    {
        num_m = num_m / 10;
        counter++;
        
    }
    return counter;
}
int res = NumCount(num);
Console.WriteLine(res);