// See https://aka.ms/new-console-template for more information
static double point(string arg)
{
    Console.Write($"Введите {arg}: ");
    double var = Int64.Parse(Console.ReadLine());
    return var;
}

void dist_xyz()
{
    double x1 = point("x1");
    double x2 = point("x2");
    double y1 = point("y1");
    double y2 = point("y2");
    double z1 = point("z1");
    double z2 = point("z2");
    Console.WriteLine($"Ваши точки : A({x1}, {y1}, {z1}) и B({x2}, {y2}, {z2})");
    double dist = Math.Round(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)), 2);
    Console.WriteLine($"Расстояние между точками = {dist}");
}
