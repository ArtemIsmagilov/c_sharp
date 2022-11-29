// See https://aka.ms/new-console-template for more information
Random rnd = new Random();
string res = Convert.ToString(rnd.Next(100, 1000));
Console.WriteLine($"Случайное число: {res}");
res = res.Remove(1, 1);
Console.WriteLine($"Результат удаления второй цифры: {res}");
