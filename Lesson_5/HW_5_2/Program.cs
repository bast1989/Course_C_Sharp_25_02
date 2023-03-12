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

int OddNumSumArr(int[] arr)
{
    int sum = 0;
    for(int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}

int[] myArr = GenArr(6, -50, 50);
PrintArr(myArr);
Console.Write("-> ");
int oddSum = OddNumSumArr(myArr);
Console.Write(oddSum);