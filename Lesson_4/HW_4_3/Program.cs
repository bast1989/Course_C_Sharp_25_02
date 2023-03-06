int[] RandArr(int num)
{
    int[] numArr = new int[num];
    for(int i = 0; i < numArr.Length; i++)
    {
        numArr[i] = new Random().Next(1, 35);
        //Console.WriteLine(numArr[i]);
    }
    return numArr;
}

void DoublePrintArr(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }

    Console.Write("-> ")
    ;
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

DoublePrintArr(RandArr(8));