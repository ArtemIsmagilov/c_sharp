double[] create_random_2d_array()
{
    (int row, int col) = (new Random().Next(2, 10), new Random().Next(2, 10));
    double[] res = new double[col];
    for (int i = 0; i < row; i += 1)
    {
        for (int j = 0; j < col; j += 1)
        {           
            int cell = new Random().Next(0, 11);
            res[j] += (double)cell/row;
            Console.Write($"{cell}\t");
        }
        Console.WriteLine();
    }
    return res;
}

void print_res(double[] arr)
{
    Console.Write("\narithmetic mean in columns -> ");
    int len = arr.Length;
    Console.Write(string.Format("{0:f1}", arr[0]) +"; ");
    for (int i = 1; i < len; i += 1)
    {
        Console.Write(string.Format("{0:f1}", arr[i]) +"; ");
    }
}
print_res(create_random_2d_array());
