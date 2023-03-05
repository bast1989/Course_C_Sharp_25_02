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
