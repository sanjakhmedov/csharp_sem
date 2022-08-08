// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Please enter the 1st number: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter the 2nd number: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
int result = firstNum % secondNum;

// int firstNum = 19;
// int secondNum = 4;

void CheckNum (int number1, int number2) 
{
    if (result == 0) 
    {
        Console.WriteLine($"Number {number1} is devidable to {number2}.");
    }
    else 
    {
        Console.WriteLine("Remain from devide " + result);
    }
}

CheckNum(firstNum, secondNum);