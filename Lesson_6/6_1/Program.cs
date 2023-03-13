string Tri(double AB, double BC, double AC)
{
    string res;
    if(AC < BC + AB && BC < AC + AB && AB < BC + AC)
    {
        return res = $"Треугольник со сторонами: {AC}, {BC}, {AB} может существовать";
    }
    else return res = $"Треугольник со сторонами: {AC}, {BC}, {AB} существовать не может существовать";
}

Console.WriteLine(Tri(34, 25, 46));
Console.WriteLine(Tri(1, 2, 3));