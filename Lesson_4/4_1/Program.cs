//Задача 1: Напишите программу, которая принимает 
//на вход число и выдаёт количество цифр в числе.


//Своё решение

int Number(int num)
{
    int i = 0;
    for(i = 0; num > 0; i++)
    {
        num /= 10;
    }
    return i;
}

int a = Number(456);
Console.WriteLine(a);
a = Number(78);
Console.WriteLine(a);
a = Number(89126);
Console.WriteLine(a);
a = Number(123456);
Console.WriteLine(a);



int SumNum(int num)
{
    int kol = 0;
    for(int i = 1; num > 0; i++)
    {
        num = num / 10;
        kol = i;
    }
    return kol;
}

Console.WriteLine(SumNum(456));
