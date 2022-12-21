int rec_slice(int res, int n, int m)
{
    if (n > m) return res;
    res += n;
    Console.Write($"{n} ");
    return rec_slice(res, n + 1, m);
}

Console.Write("Enter number the N: ");
int n = Int32.Parse(Console.ReadLine());
Console.Write("Enter number the M: ");
int m = Int32.Parse(Console.ReadLine());
int res = 0;
Console.WriteLine($"-> {rec_slice(res, n, m)}");
