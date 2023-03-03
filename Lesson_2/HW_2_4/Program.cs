string func(int num)
{
    if(num >= 1 && num <= 5) return "Это рабочий день";
    else if(num == 6 || num == 7) return "Это выходной день";
    else return "Такого дня нет";
}

Console.WriteLine(func(-1));
Console.WriteLine(func(0));
Console.WriteLine(func(1));
Console.WriteLine(func(2));
Console.WriteLine(func(3));
Console.WriteLine(func(4));
Console.WriteLine(func(5));
Console.WriteLine(func(6));
Console.WriteLine(func(7));
Console.WriteLine(func(8));