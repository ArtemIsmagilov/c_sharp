// See https://aka.ms/new-console-template for more information
void cub()
{
    Console.Write("Введите число: ");
    int dig = Int32.Parse(Console.ReadLine());
    int start = 1;
    if (dig >= start)
    {
        Console.Write("1");
    }
    while (dig > start)
    {
        start += 1;
        Console.Write($", {Math.Pow(start, 3)}");
    }
}
