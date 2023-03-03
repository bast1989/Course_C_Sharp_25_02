//Текст программы без функции

//int num = new Random().Next(100, 1000);
//int result = num % 10;
//Console.WriteLine(num);
//Console.WriteLine(result);

//Пытаюсь разобраться с различиями void и int.

// void ничего не возвращает, вывод работы функции делается в теле функции,
// здесь это Console.WriteLine(num); и Console.WriteLine(result);. Для вызова
// функции достаточно просто её вызвать ost();

void ost()
{
    int num = new Random().Next(100, 1000);
    int result = num % 10;
    Console.WriteLine(num);
    Console.WriteLine(result);
}

ost();

// int обязательно вазвращает из функции целое число при помощи конструкции
// ruturn. Если в теле функции с int нет return будет выведена ошибка. При вызове 
// функции простым её объявление быдет отображаться только работа проделанная в теле 
// функции, здесь это Console.WriteLine(num);. Для того что бы получить доступ к возвращаемым
// функцией данным с ней необходимо произвестикакие либо действия: например вывести её
// в консоль как в нашем примере Console.WriteLine(i_ost()); или присвоить её переменной 
// и дальше производить с ней какие либо действия.

int i_ost()
{
    int num = new Random().Next(100, 1000);
    int result = num % 10;
    Console.WriteLine(num);
    return result;
}

Console.WriteLine(i_ost());

//Код с семинара

int num = new Random().Next(100, 1000);
Console.WriteLine(num);
Console.WriteLine(num % 10);

int TakeNum(int num)
{
    Console.WriteLine(num);
    return num % 10;
}

int result = TakeNum(new Random().Next(100, 1000));
Console.WriteLine(result);