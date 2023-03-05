// 2. Напишите программу, которая принимает на вход координаты
//    двух точек и находит расстояние между ними в 2D пространстве.
//    https://ru.onlinemschool.com/math/library/analytic_geometry/point_point_length/

// Своё решение

void DistXY()
{

    Console.WriteLine("Введите координаты двух точек");

    Console.WriteLine("Координата X точки A равна: ");
    double AX = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Координата Y точки A равна: ");
    double AY = int.Parse(Console.ReadLine()!);



    Console.WriteLine("Координата X точки B равна: ");
    double BX = int.Parse(Console.ReadLine()!);    
    Console.WriteLine("Координата Y точки B равна: ");
    double BY = int.Parse(Console.ReadLine()!);

    double AB = Math.Sqrt(Math.Pow(BX - AX, 2) + Math.Pow(BY - AY, 2));
    double res = Math.Round(AB, 2);
    Console.WriteLine(res);

}

DistXY();

Console.WriteLine();

double Distance(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}

Console.WriteLine(Distance(3, 6, 2, 1));
Console.WriteLine(Distance(7, -5, 1, -1));