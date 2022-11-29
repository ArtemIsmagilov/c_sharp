// See https://aka.ms/new-console-template for more information
// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введте число: ");
int a = Int32.Parse(Console.ReadLine());
int res = 2;
if(a >= 4)
{
    Console.Write($"{res}");
    res += 2;
}
while(res <= a)
{
    Console.Write($", {res}");
    res += 2;
}
