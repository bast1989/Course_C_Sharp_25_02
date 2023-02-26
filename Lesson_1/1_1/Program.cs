Console.WriteLine("Введите два числа. Число один: ");
int squ = int.Parse(Console.ReadLine()!);

Console.WriteLine("Число два: ");
int num = int.Parse(Console.ReadLine()!);

if (squ / num == num)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

