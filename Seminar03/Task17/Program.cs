Console.Write("Enter coordinate for X: ");
int x = Convert.ToInt32(ReadLine());
Console.Write("Enter coordinate for Y: ");
int y = Convert.ToInt32(ReadLine());

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
    else // if (x1 > 0 && y1 < 0) 
    {
        return 4;
    }
}

XY(x, y);