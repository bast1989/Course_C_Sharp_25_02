string Multi(int numA, int numB)
{
    if (numA % numB == 0) return "кратно";
    else return "не кратно, отаток " + numA % numB;
}

Console.WriteLine(Multi(34, 5));
Console.WriteLine(Multi(16, 4));

Console.WriteLine();

void Multi2(int numA, int numB)
{
    if (numA % numB == 0) Console.WriteLine("кратно");
    else Console.WriteLine($"не кратно, отаток {numA % numB}");
}

Multi2(34, 5);
Multi2(16, 4);