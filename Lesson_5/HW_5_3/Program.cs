int[] GenArr(int num, int min, int max)
{
    int[] intArr = new int[num];

    for(int i = 0; i < intArr.Length; i++)
    {
        intArr[i] = new Random().Next(min, max + 1);        
    }

    return intArr;
}

void PrintArr(int[] intArr)
{
    for(int i = 0; i < intArr.Length; i++)
    {
        Console.Write(intArr[i] + " ");
    }
}

int MinMaxNumArr(int[] intArr)
{
    int max = intArr[0];
    int min = intArr[0];

    for(int i = 0; i < intArr.Length; i++)
    {
        if(intArr[i] > max) max = intArr[i];
        if(intArr[i] < min) min = intArr[i];
    }

    int diff = max - min;
    return diff;
}

int[] myArr = GenArr(10, 1, 100);
PrintArr(myArr);
Console.Write("-> ");
int res = MinMaxNumArr(myArr);
Console.Write(res);
