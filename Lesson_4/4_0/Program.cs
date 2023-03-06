//Задача 1: Напишите программу, которая принимает 
//на вход число (А) и выдаёт сумму чисел от 1 до А.


void SumNum()
{
    Console.WriteLine("Введите число");
    int num = int.Parse(Console.ReadLine()!);
    int res = 0;
    for(int i = 1; i <= num; i++)
    {
        res += i;
    }
    Console.WriteLine($"Результат равен: {res}");
}

SumNum();

int SumNum2(int num)
{
    int all_sum = 0;
    for(int i = 1; i <= num; i++)
    {
        all_sum += i;
    }
    return all_sum;
}

Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine()!);
int resNum = SumNum2(A);
Console.WriteLine(resNum);