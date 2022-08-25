// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
// 13 -> 1101

Console.Write("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());

int DecimalToBinary(int num)
{
    int res = 0;
    int mult = 1;
    while (num > 0)
    {
        res += num % 2 * mult;
        num /= 2;
        mult *= 10;
    }
    return res;
}
int result = DecimalToBinary(number);
Console.WriteLine(result);
