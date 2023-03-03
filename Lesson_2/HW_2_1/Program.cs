int func(int num)
{
    if(num < 0) num = -num;
    while(num > 100)
    {
        num /= 10;
    }
    int res = num % 10;
    return res;

}

Console.WriteLine(func(456));
Console.WriteLine(func(782));
Console.WriteLine(func(918)); 