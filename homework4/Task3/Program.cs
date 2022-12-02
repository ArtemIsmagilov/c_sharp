// See https://aka.ms/new-console-template for more information


void func3(string text)
{
    string[] nums = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    string res = string.Join(", ", nums);
    Console.WriteLine(String.Concat($"{res} -> ", "[", $"{res}", "]"));
}

Console.Write("Введите числа массива через пробел: ");
func3(text: Console.ReadLine());
