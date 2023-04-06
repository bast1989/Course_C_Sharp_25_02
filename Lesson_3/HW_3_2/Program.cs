double Graph(double AX, double AY, double AZ, double BX, double BY, double BZ)
{
    double AB = Math.Sqrt(Math.Pow(BX - AX, 2) + Math.Pow(BY - AY, 2) + Math.Pow(BZ -AZ, 2));
    return Math.Round(AB, 2);
}

double graph = Graph(3, 6, 8, 2, 1, -7);
Console.WriteLine(graph);

graph = Graph(7, -5, 0, 1, -1, 9);
Console.WriteLine(graph);
