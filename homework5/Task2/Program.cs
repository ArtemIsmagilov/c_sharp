// See https://aka.ms/new-console-template for more information
int[] get_random_arr()
{
    int len = new Random().Next(4, 10);
    int[] arr = new int[len];
    for (int i = 0; i < len; i += 1)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}

int sum_arr(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i += 2)
    {
        res += arr[i];
    }
    return res;
}

void result()
{
    int[] r_arr = get_random_arr();
    int s = sum_arr(r_arr);
    Console.Write($"Случайный массив из 3-х значных чисел: [ {r_arr[0]}");
    int len = r_arr.Length;
    for (int i = 1; i < len; i += 1)
    {
        Console.Write($", {r_arr[i]}");
    }
    Console.WriteLine($" ] -> Сумма элементов, стоящих на нечётных позициях = {s}");
}


result();
