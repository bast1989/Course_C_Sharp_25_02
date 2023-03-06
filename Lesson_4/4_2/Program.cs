//Задача 2: Напишите программу, которая 
//принимает на вход число N и выдаёт 
//произведение чисел от 1 до N. 

int Multi(int num)
{
    int res = 1;
    for (int i = 1; i <= num; i++)
    {
        res *= i;
    }
    return res;
}

Console.WriteLine(Multi(4));

Console.WriteLine(Multi(5));

Console.WriteLine(Multi(6));

Console.WriteLine(Multi(9));

