

Console.WriteLine("Enter the intiger number: ");
int number = Convert.ToInt32(Console.ReadLine());

void NatularNumber(int num)
{
    if(num == 0) return;
    NatularNumber(num - 1);
    Console.Write($"{num} ");
}

NatularNumber(number);