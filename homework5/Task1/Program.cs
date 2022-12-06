// See https://aka.ms/new-console-template for more information
void func1(string text)
{
    int count = 0;

    string[] nums = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    for (int i = 0; i < nums.Length; i += 1)
    {
        int dig = int.Parse(nums[i]);
        if (dig % 2 == 0)
        {
            count += 1;
        }
    }
    string res = string.Join(", ", nums);
    Console.WriteLine(String.Concat($"[{res}] -> чётных чисел: {count}"));
}

Console.Write("Введите случайные числа массива: ");
func1(text: Console.ReadLine());