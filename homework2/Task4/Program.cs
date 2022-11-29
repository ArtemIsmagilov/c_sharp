// See https://aka.ms/new-console-template for more information
Console.Write("Введите любой день: ");
double day = Int64.Parse(Console.ReadLine());
if(day % 6 == 0)
{
    Console.WriteLine("Да");
}
else if(day % 7 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.Write("Нет");
}