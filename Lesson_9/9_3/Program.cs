int DegNum(int A, int B)
{
    if(B == 0) return 1;
    return DegNum(A, B - 1) * A;
}


int num_1 = int.Parse(Console.ReadLine()!);
int num_2 = int.Parse(Console.ReadLine()!);
int deg = DegNum(num_1, num_2);
Console.WriteLine(deg);