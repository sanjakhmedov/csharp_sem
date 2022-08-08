// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write("Enter 1st the number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter 2nd the number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool CheckSquare(int number1, int number2)
{
    return number1 * number1 == number2 || number2 * number2 == number1;
}

// string res = CheckSquare(num1, num2) ? "Yes" : "No";
Console.WriteLine(CheckSquare(num1, num2));