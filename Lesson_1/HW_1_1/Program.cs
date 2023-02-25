// Задача 1: Напишите программу, которая на вход принимает 
// два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите два числа для сравнения. Число один: ");
int num_a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Число два: ");
int num_b = int.Parse(Console.ReadLine()!);

if (num_a > num_b) Console.WriteLine("Число " + num_a + " больше числа " + num_b);
else if (num_b > num_a) Console.WriteLine("Число " + num_b + " больше числа " + num_a);
else Console.WriteLine("Числа равны");