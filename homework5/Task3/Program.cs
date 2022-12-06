// See https://aka.ms/new-console-template for more information
float max_sub_min(float[] input_list)
{   
    float mx = input_list.Max();
    float mn = input_list.Min();
    Console.WriteLine($"Максимальное: {mx}\nМинимальное: {mn}");
    float res =  mx+mn;
    return res;
}

float[] parse_input(string text)
{
    string[] nums = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    float[] digits = new float[nums.Length];
    for (int i = 0; i < nums.Length; i += 1)
    {
        digits[i] = float.Parse(nums[i]);
    }
    return digits;
}

Console.Write("Введите случайные вещественные числа массива, например 1,9 2,1 -0,9: ");
Console.WriteLine(max_sub_min(parse_input(text: Console.ReadLine())));
