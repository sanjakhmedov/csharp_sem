// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

// Console.Write("Enter the integer number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int square = num * num;
// Console.WriteLine($"Square of the {num} is {square}");

Console.Write("Enter the first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2*num2) {
    Console.WriteLine($"{num1} = square of {num2}");
} else {
    Console.WriteLine($"{num1} is not the square of {num2}");
};


