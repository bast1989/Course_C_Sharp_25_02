// Реализация метматическими действиями

void SumNum(int num)
{
    int tmp = num;
    int sum = 0;
    for(int i = 0; num > 0; i++)
    {
        sum = sum + num % 10;
        num /= 10;
    }
    Console.WriteLine($"{tmp} -> {sum}");
}

SumNum(452);
SumNum(82);
SumNum(9012);

Console.WriteLine();

// Реализация строкой

void SumNum2(string strNum)
{    
    int sum = 0;
    for (int i = 0; i < strNum.Length; i++)
    {
        int tmp = int.Parse(strNum[i].ToString());
        sum = sum + tmp;
    }
    Console.WriteLine($"{strNum} -> {sum}");
}

SumNum2("452");
SumNum2("82");
SumNum2("9012");