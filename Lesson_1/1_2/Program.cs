Console.WriteLine("Введите число соответствующее дню недели: ");
int day = int.Parse(Console.ReadLine()!);

if (day == 3) Console.WriteLine("Среда");
else if (day == 5) Console.WriteLine("Пятница");
else Console.WriteLine("Я незнаю такого дня недели.");
