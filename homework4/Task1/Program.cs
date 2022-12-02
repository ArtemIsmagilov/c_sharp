// See https://aka.ms/new-console-template for more information
void func(string text)
{
    string[] nums = text.Split(' ');
    int num = Int32.Parse(nums[0]);
    int num2 = Int32.Parse(nums[1]);
    int res = 1;
    for (int i=0; num2 > i; i += 1)
    {
        res *= num;

    }
    Console.WriteLine(String.Concat(text.Replace(" ", ", "), " -> ", res));
}

Console.Write("Введите число и степень этого числа: ");

func(text: Console.ReadLine());

