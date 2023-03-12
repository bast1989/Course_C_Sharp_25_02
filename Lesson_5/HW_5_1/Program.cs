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

int EvenNumArr(int[] intArr)
{
    int count = 0;
    for (int i = 0; i < intArr.Length; i++)
    {
        if(intArr[i] % 2 == 0) count++;
    }
    return count;
}

int[] myArr = GenArr(6, 100, 999);
PrintArr(myArr);
Console.Write("-> ");
int even = EvenNumArr(myArr);
Console.Write(even);