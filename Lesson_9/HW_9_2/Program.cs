int SumNum(int M, int N)
{
    if(N == M - 1) return 0;
    return SumNum(M, N - 1) + N;
}


int num_1 = int.Parse(Console.ReadLine()!);
int num_2 = int.Parse(Console.ReadLine()!);
int deg = SumNum(num_1, num_2);
Console.WriteLine(deg);