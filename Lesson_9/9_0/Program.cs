void ValueSet(int N)
{
    if(N == 0) return;
    ValueSet(N - 1);
    Console.Write($"{N} ");
}

int num = int.Parse(Console.ReadLine()!);
ValueSet(num);