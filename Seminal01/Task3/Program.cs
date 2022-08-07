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