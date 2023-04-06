
int DecToBin(int num)
{
    string toBin = "";
    for (int i = 0; num > 0; i++)
    {
        toBin += num % 2;
        num /= 2;        
    }
    char[] toBinArr = toBin.ToCharArray();
    Array.Reverse(toBinArr);
    toBin = String.Join("",toBinArr);
    num = int.Parse(toBin);    
    return num;
}

int decBin = DecToBin(156);
Console.WriteLine(decBin);
decBin = DecToBin(12);
Console.WriteLine(decBin);


string conver(int num_1)
{
    string result = "";
    while(num_1 > 0)
    {
        result = num_1 % 2 + result;    //<- Строка отвечет за инверсию, за это отвечает конкатенция(прибавление) переменной, в конце выражения
        num_1 /= 2;                     // в строку сначала присваивается остаток от num_1 % 2 а только потом содержимое всей остальной строки.

    }
    return result;

}

Console.WriteLine(conver(156));
Console.WriteLine(conver(12));