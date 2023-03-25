void ValueSet(int start, int finish)
{
    if(finish == start - 1) return;
    ValueSet(start, finish - 1);
    if(finish % 2 == 0) Console.Write($"{finish} ");
}



int num_1 = int.Parse(Console.ReadLine()!);
int num_2 = int.Parse(Console.ReadLine()!);
ValueSet(num_1, num_2);