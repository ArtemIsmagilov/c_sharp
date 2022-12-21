// See https://aka.ms/new-console-template for more information
int rec_nums(int n)
{
    if (n <= 0) return 0;
    if (n % 2 == 0) Console.Write($"{n} ");
    return rec_nums(n - 1);
}

Console.Write("Enter the number: ");
int num = Int32.Parse(Console.ReadLine());
rec_nums(num);