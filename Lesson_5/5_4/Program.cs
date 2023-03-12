int[] intArr = {1, 2, 3, 4, 5};
//int[] intArr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};
int[] numArr = {6, 7, 3, 6};
//int[] numArr = {8, 17, 21, 36, 4, 3, 6, 51};


void PrintArr(int[] intArr)
{
    for(int i = 0; i < intArr.Length; i++)
    {
        Console.Write(intArr[i] + " ");
    }
}

int[] SumValArr(int[] arr)
{
    int[] sumArr;
    if(arr.Length % 2 == 0)
    {
        sumArr = new int[arr.Length / 2];
        int count = 0;

        for(int i = 0; i < arr.Length / 2; i++)
        {
            sumArr[i] = arr[i] * arr[arr.Length - (1 + count)];
            count++;
        }
        return sumArr;
    }
    else
    {
        sumArr = new int[arr.Length / 2 + 1];
        int count = 0;

        for(int i = 0; i < arr.Length / 2; i++)
        {
            sumArr[i] = arr[i] * arr[arr.Length - (1 + count)];
            count++;
        }
        sumArr[^1] = arr.Length / 2 + 1;
        return sumArr;
    }   
}


int[] myArr = SumValArr(numArr);
PrintArr(myArr);
Console.WriteLine();
myArr = SumValArr(intArr);
PrintArr(myArr);


