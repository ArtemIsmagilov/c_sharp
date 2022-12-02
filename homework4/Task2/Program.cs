// See https://aka.ms/new-console-template for more information
void func2()
{
    int res = 0;
    string text = Console.ReadLine();
    for (int i = 0; i < text.Length; i += 1)
    {
        string str  = Convert.ToString(text[i]);
        res += Convert.ToInt32(str);
    }
    Console.WriteLine(String.Concat(text, " -> ", res));
}


Console.Write("Введите число: ");
func2();
