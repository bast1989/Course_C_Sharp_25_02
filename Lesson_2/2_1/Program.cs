//int num = 68;
//Console.WriteLine(num / 10);
//Console.WriteLine(num % 10);

int max_num(int num)
{
    Console.WriteLine(num);
    int num1 = num / 10;
    int num2 = num % 10;
    if(num1 > num2) return num1;
    else return num2;
}

Console.WriteLine(max_num(new Random().Next(10, 100)));