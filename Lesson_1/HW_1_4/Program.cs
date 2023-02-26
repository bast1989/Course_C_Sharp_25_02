// Задача 4: Напишите программу, которая на вход принимает число 
// (n), а на выходе показывает все чётные числа от 1 до N.

int min = 2;

Console.WriteLine("Введите число N что бы посмотреть все чётные числа от 1 до N: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine("Ряд чётных чисел от 1 до " + n + " равен: ");

while (min <= n) 
{
    Console.Write(min + " ");
    min = min + 2;
}
