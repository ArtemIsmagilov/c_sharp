// See https://aka.ms/new-console-template for more information
void more_zero(string text)
{
    text += " ";

    int len = text.Length;
    string dig = "";
    int count = 0;
    for (int i = 0; i < len; i += 1)
    {
        if (text[i] == ' ' && dig.Length > 0)
        {
            float float_dig = float.Parse(dig);
            dig = "";
            if (float_dig > 0)
            {
                count += 1;
            }
        }
        else if (text[i] != ' ')
        {
            dig += Convert.ToString(text[i]);
        }
    }
    Console.WriteLine($"-> Кол-во чисел > 0: {count}");

}
 Console.Write("Введите вещественные числа через пробел: ");
more_zero(Console.ReadLine());
