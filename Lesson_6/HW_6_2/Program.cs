int b1 = 2;
int k1 = 5;
int b2 = 4;
int k2 = 9;

void BS(double b_1, double k_1, double b_2, double k_2)
{
    double x = (b_2 - b_1) / (k_1 - k_2);
    double y = k_1 * (b_2 - b_1) / (k_1 - k_2) + b_1;

    Console.WriteLine($"b1 = {b_1}, k1 = {k_1}, b2 = {b_2}, k2 = {k_2} -> ({x};{y})");
}

BS(b1, k1, b2, k2);