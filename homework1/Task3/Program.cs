// See https://aka.ms/new-console-template for more information
// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите чётное или нечётное число");
int a = Int32.Parse(Console.ReadLine());
if(a % 2 == 0) 
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
