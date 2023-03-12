int[] GenArr(int num, int min, int max)
{
    int[] intArr = new int[num];

    for(int i = 0; i < intArr.Length; i++)
    {
        intArr[i] = new Random().Next(min, max + 1);
        //Console.WriteLine(intArr[i]);
    }

    return intArr;
}

string NumToArr(int[] intArr, int num)
{
    int count = 0;
    for(int i = 0; i < intArr.Length; i++)
    {
        if(intArr[i] == num) count++;
    }
    if(count > 0) return "да";
    else return "нет";
}

void PrintArr(int[] intArr)
{
    for(int i = 0; i < intArr.Length; i++)
    {
        Console.Write(intArr[i] + " ");
    }
}

int[] myArr = GenArr(8, -8, 8);
PrintArr(myArr);
Console.Write("-> ");
string numTo = NumToArr(myArr, 7);
Console.Write(numTo);