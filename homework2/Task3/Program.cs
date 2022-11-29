// See https://aka.ms/new-console-template for more information
Console.Write("Введите любое  натуральное число: ");
int digit = Int32.Parse(Console.ReadLine());
string res = Convert.ToString(digit);
if(res.Length > 2)
{
    Console.WriteLine(res[2]);
}
else
{
    Console.WriteLine("третьей цифры нет");
}
