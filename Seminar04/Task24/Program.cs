Console.Write("Enter the number: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = 0;
for (int i = 1; i <= a; i++)
{
    result += i;
}
Console.WriteLine(result);