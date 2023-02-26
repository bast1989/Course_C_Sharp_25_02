void func(int num)
{
    if(num < 100)
    {
        Console.WriteLine("Тоетьей цифры нет");
    }
    else
    {
        while(num > 999)
        {
            num /= 10;
        }
        num %= 10;
        Console.WriteLine(num);
    }
}

func(645);
func(78);
func(32679);
