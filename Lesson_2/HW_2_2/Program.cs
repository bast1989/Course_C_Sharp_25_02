int func()
{
    int num = new Random().Next(100, 1000);
    int numA = num / 100;
    int numB = num % 10;
    Console.WriteLine(num);
    Console.WriteLine(numA);
    Console.WriteLine(numB);
    return numA * 10 + numB;
}

Console.WriteLine(func());