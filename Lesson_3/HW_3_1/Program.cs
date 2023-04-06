// Задача 1: Напишите программу, которая принимает на 
// вход пятизначное число и проверяет, является ли оно 
// палиндромом.

// Реализация строкой

string Palindrome()
{
    Console.WriteLine("Введите пятизначное число, что бы узнать является ли оно палиндромом.");
    string strNum = Console.ReadLine()!;
    if(strNum[0] == strNum[strNum.Length - 1] && strNum[1] == strNum[strNum.Length - 2]) return $"Число {strNum} палиндром";
    else return $"Число {strNum} не палиндром";
}

string res = Palindrome();
Console.WriteLine(res);

// Реализация c математическими операциями

void Palindrome2(int num)
{
    int sample = num;
    int a1 = num % 10;
    num /= 10;
    int b1 = num % 10;
    num /= 10;
    num /= 10;
    int b2 = num % 10;
    num /= 10;
    int a2 = num % 10;

    if(a1 == a2 && b1 == b2) Console.WriteLine($"Число {sample} палиндром");
    else Console.WriteLine($"Число {sample} не палиндром");;
}

Console.WriteLine("Введите пятизначное число, что бы узнать является ли оно палиндромом.");
int number = int.Parse(Console.ReadLine()!);
Palindrome2(number);


// Реализация массивом и строкой где символы переводят в цифры

string Palindrome3(string numStr)
{
    int[] numArr = new int[5];
    //int i = 0;
    for(int i = 0; i < 5; i++)
    {
        numArr[i] = int.Parse(numStr[i].ToString());
             
        
    }
    if(numArr[0] == numArr[numArr.Length - 1] && numArr[1] == numArr[numArr.Length - 2]) return $"Число {numStr} палиндром";
    else return $"Число {numStr} не палиндром";
    
}

string s = Palindrome3("54321");
Console.WriteLine(s);



s = Palindrome3("03130");
Console.WriteLine(s);






