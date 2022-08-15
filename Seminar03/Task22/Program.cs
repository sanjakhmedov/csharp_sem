Console.Write("Enter the number: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= n)
{
    Console.WriteLine($"Square of {i} => {i*i}");
    i++;
}