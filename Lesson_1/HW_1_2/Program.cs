// Задача 2: Напишите программу, которая принимает 
// на вход три числа и выдаёт максимальное из этих

Console.WriteLine("Введите три числа для поиска максимального. Число один: ");
int num_a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Число два: ");
int num_b = int.Parse(Console.ReadLine()!);

Console.WriteLine("Число три: ");
int num_c = int.Parse(Console.ReadLine()!);

int max = num_a;

if (num_b > max) max = num_b;
if (num_c > max) max = num_c;

Console.WriteLine("Максимальное число из трёх представленных: " + max);