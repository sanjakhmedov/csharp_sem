Console.Write("Enter the first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2*num2) {
    Console.WriteLine($"{num1} = square of {num2}");
} else {
    Console.WriteLine($"{num1} is not the square of {num2}");
};