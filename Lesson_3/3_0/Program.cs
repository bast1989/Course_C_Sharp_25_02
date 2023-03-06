// 1. Напишите программу, которая принимает на вход координаты точки (X и Y),
//    причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости,
//    в которой находится эта точка.

// Своё решение

string graph()
{

    int x = int.Parse(Console.ReadLine()!);
    int y = int.Parse(Console.ReadLine()!);
    string result = $"X = {x}, Y = {y} - введите отличное от 0 значение";

    if(x > 0 && y > 0) result = $"X = {x}, Y = {y} - точка находится в плоскости 1";
    if(x > 0 && y < 0) result = $"X = {x}, Y = {y} - точка находится в плоскости 4";
    if(x < 0 && y < 0) result = $"X = {x}, Y = {y} - точка находится в плоскости 3";
    if(x < 0 && y > 0) result = $"X = {x}, Y = {y} - точка находится в плоскости 2";

    return result;

}

Console.WriteLine(graph());

Console.WriteLine();

void Quarters(int x, int y)
{
    if (x == 0 || y == 0)
        Console.WriteLine("x = 0, y = 0");
    else if (x > 0 && y > 0)
        Console.WriteLine("I");
    else if (x < 0 && y > 0)
        Console.WriteLine("II");
    else if (x < 0 && y < 0)
        Console.WriteLine("III");
    else if (x > 0 && y < 0)
        Console.WriteLine("IV");
}

int num_1 = int.Parse(Console.ReadLine()!);
int num_2 = int.Parse(Console.ReadLine()!);
Quarters(num_1, num_2);

Console.WriteLine();

void Quarters2(int x, int y)
{
    if (x > 0) 
    {
        if (y > 0)
        {
            Console.WriteLine("First quarter - I");
        }
        else if (y < 0)
        {
            Console.WriteLine("Fourth quarter - IV");
        }        
    }
    else if (x < 0)
    {
        if (y > 0)
        {
            Console.WriteLine("Second quarter - II");
        }
        else if (y < 0)
        {
            Console.WriteLine("Third quarter - III");
        }               
    }        
}

Quarters2(2, 2);
Quarters2(-2, 2);
Quarters2(-2, -2);
Quarters2(2, -2);

