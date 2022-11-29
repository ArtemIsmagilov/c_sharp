// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information

void palindrome()
{
    Console.Write("Введите любое натуральное число: ");
    string digits = Console.ReadLine();
    int first = 0;
    int last = digits.Length - 1;
    while (first < last)
    {
        if (digits[first] != digits[last])
        {
            Console.WriteLine("Нет");
            return;
            
        }
        first += 1;
        last -= 1;
    }
    Console.WriteLine("Да");
}

