// See https://aka.ms/new-console-template for more information

// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.WriteLine("Введите 2 числа: ");
int a = Int32.Parse(Console.ReadLine());
int b = Int32.Parse(Console.ReadLine());
if(a > b)
{
    Console.WriteLine($"Максимальное: {a}\nМинимальное: {b}");
}
else
{
    Console.WriteLine($"Максимальное: {b}\nМаксимальное: {a}");
}