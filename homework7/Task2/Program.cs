// See https://aka.ms/new-console-template for more information
double[, ] create_random_2d_array()
{
    (int row, int col) = (new Random().Next(2, 10), new Random().Next(2, 10));
    double [, ] arr_2d = new double[row, col];
    for (int i = 0; i < row; i += 1)
    {
        for (int j = 0; j < col; j += 1)
        {           
            int cell = new Random().Next(-50, 51);
            arr_2d[i, j] = cell;
            Console.Write($"{cell}\t");
        }
        Console.WriteLine();
    }
    return arr_2d;
}

void get_cell(double[, ] matrix)
{
    Console.WriteLine("Input POSITION for element. First row, second column.");
    (int x, int y) = (Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()));
    (int row, int col) = (matrix.GetLength(0), matrix.GetLength(1));
    Console.WriteLine((row, col, x, y));
    if ((1 <= x & x <= row) & (1 <= y & y <= col)) Console.WriteLine($"$Element in position ({x}, {y}) -> {matrix[x-1, y-1]}");
    else Console.WriteLine($"Element not found on position ({x}, {y})");
}


Console.WriteLine("Create random matrix...");
get_cell(create_random_2d_array());
