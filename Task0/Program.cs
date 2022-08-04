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

// Console.Write("Enter the first integer number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the second integer number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 == num2*num2) {
//     Console.WriteLine($"{num1} = square of {num2}");
// } else {
//     Console.WriteLine($"{num1} is not the square of {num2}");
// };


Console.WriteLine("Enter the enteger number from 1 to 7 inclusive: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1) {
    Console.WriteLine($"{number} = Monday");
} else if (number == 2) {
    Console.WriteLine($"{number} = Tuesday");
} else if (number == 3) {
    Console.WriteLine($"{number} = Wednesday");
} else if (number == 4) {
    Console.WriteLine($"{number} = Thursday");
} else if (number == 5) {
    Console.WriteLine($"{number} = Friday");
} else if (number == 6) {
    Console.WriteLine($"{number} = Saturday");
} else if (number == 7) {
    Console.WriteLine($"{number} = Sunday");
} else {
    Console.WriteLine("You entered wrong number");
};