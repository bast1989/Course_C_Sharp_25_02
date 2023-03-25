int SumNum(int N)
{
    if(N == 0) return 0;
    return SumNum(N / 10) + N % 10;
}


int num = int.Parse(Console.ReadLine()!);
int sum = SumNum(num);
Console.WriteLine(sum);