string SqrStr(int num)
{
    string res = "";
    for(int i = 1; i <= num; i++)
    {
        double sq = Math.Pow(i, 2);
        res += sq.ToString() + " ";
    }

    return res;
}
Console.WriteLine(SqrStr(5));












void Squares(int num)
{
    int i = 1;
    Console.Write($"{num} -> ");

    while (num >= i)
    {
        Console.Write($"{Math.Pow(i, 2)}, ");
        i++;
    }
    Console.WriteLine();
}

int num = int.Parse(Console.ReadLine()!);
Squares(num);
















// 2 вариант

void Squares2(int n)
{
    double[] nums = new double[n];
    int index = 0;

    Console.Write($"{n} -> ");

    while (index < n)
    {
        nums[index] = Math.Pow((index + 1), 2);
        Console.Write($"{nums[index]}, ");
        index += 1;
    }    
    Console.WriteLine();
}

int num1 = int.Parse(Console.ReadLine()!);
Squares2(num);












// 3 вариант

double[] Squares3(int n)
{
    double[] nums = new double[n];
    int index = 0;

    while (index < n)
    {
        nums[index] = Math.Pow((index + 1), 2);
        index += 1;
    }

    return nums;
}

void PrintList(int num)
{
    double[] arr = Squares3(num); 
    int index = 0;
    
    Console.Write($"{num} -> ");

    while (index < arr.Length)
    {
        Console.Write($"{arr[index]}, ");
        index += 1;
    }
}

int num2 = int.Parse(Console.ReadLine()!);
PrintList(num);