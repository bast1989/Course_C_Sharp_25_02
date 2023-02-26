string Multi(int num)
{
    if (num % 7 == 0 && num % 23 == 0) return "да";
    else return "нет";
}

Console.WriteLine(Multi(14));
Console.WriteLine(Multi(46));
Console.WriteLine(Multi(161));

Console.WriteLine();

void Multi2(int num)
{
    if (num % 7 == 0 && num % 23 == 0) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}

Multi2(14);
Multi2(46);
Multi2(161);