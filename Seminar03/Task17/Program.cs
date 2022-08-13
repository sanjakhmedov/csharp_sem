Console.Write("Enter coordinate for X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter coordinate for Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int XY(int x1, int y1)
{
    if (x1 > 0 && y1 > 0) {
        return 1;
    } 
    else if (x1 < 0 && y1 > 0) 
    {
        return 2;
    }
    else if (x1 < 0 && y1 < 0) 
    {
        return 3;
    }
    else if (x1 > 0 && y1 < 0) 
    {
        return 4;
    } 
    else
    {
        return 0;
    }
}

Console.WriteLine(XY(x, y));