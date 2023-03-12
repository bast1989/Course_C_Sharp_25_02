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

int ToSection(int[] intArr)
{
    int count = 0;
    for(int i = 0; i < intArr.Length; i++)
    {
        if(intArr[i] >= 10 && intArr[i] <= 99)
        {
            count++;
        }
    }
    return count;
}

int[] myArr = GenArr(123, 0, 123);
PrintArr(myArr);
Console.Write("-> ");
int countArr = ToSection(myArr);
Console.Write(countArr);