// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите 3 числа: ");
int a = Int32.Parse(Console.ReadLine());
int b = Int32.Parse(Console.ReadLine());
int c = Int32.Parse(Console.ReadLine());
int maximum = Math.Max(a,b);
maximum = Math.Max(maximum, c);
Console.WriteLine($"Масимальное число из чисел: {maximum}");
