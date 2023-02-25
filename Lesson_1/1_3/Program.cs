Console.WriteLine("Введиде произвольное число: ");
int num = int.Parse(Console.ReadLine()!);
int reverse = -num;

while (reverse <= num)
{
    Console.Write(reverse + " ");
    reverse++;
}
