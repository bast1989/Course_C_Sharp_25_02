void NumSqr(int A, int B)
{
    int res = A;
    for(int i = 1; i < B; i++)
    {
        res = res * A;
    }
    Console.WriteLine($"{A}, {B} -> {res}");
}

NumSqr(3, 5);
NumSqr(2, 4);