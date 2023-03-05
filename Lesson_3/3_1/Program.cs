// 1. Напишите программу, которая по заданному номеру четверти,
//    показывает диапазон возможных координат точек в этой четверти (x и y).

// Своё решение

void dot(int a)
{
    string res = "Вы ввели неверное значение";
    if(a == 1) res = $"Вы ввели четверть {a}. x > 0, y > 0";
    if(a == 4) res = $"Вы ввели четверть {a}. x > 0, y < 0";
    if(a == 3) res = $"Вы ввели четверть {a}. x < 0, y < 0";
    if(a == 2) res = $"Вы ввели четверть {a}. x < 0, y > 0";

    Console.WriteLine(res);
}

Console.WriteLine();

int num = int.Parse(Console.ReadLine()!);
dot(num);

void Coordinates(string num)
{
    if (num == "I")
    {
        Console.WriteLine("x > 0, y > 0");
    }
    else if (num == "II")
    {
        Console.WriteLine("x < 0, y > 0");
    }
    else if (num == "III")
    {
        Console.WriteLine("x < 0, y < 0");
    }
    else if (num == "IV")
    {
        Console.WriteLine("x > 0, y < 0");
    }
    else
    {
        Console.WriteLine("The data is not correct!");
    }
}

string num2 = Console.ReadLine()!;
Coordinates(num2);