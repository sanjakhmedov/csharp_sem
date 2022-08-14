// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.Write("Quarter: ");
int quarter = Convert.ToInt32(Console.ReadLine());

string Quarter (int quarter_m) 
{
    if (quarter_m == 1) return "x > 0, y > 0";
    else if (quarter_m == 2) return "x < 0, y > 0";
    else if (quarter_m == 3) return "x < 0, y < 0";
    else if (quarter_m == 4) return "x > 0, y < 0";
    else return "incorrect quarter";
}

Console.WriteLine(Quarter(quarter));