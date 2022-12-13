// See https://aka.ms/new-console-template for more information
double[, ] create_2d_array(int row, int col)
{
    Console.WriteLine("Input range of random numbers. Row and column");
    (double mn, double mx) = (double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
    if (mx < mn) (mx, mn) = (mn, mx);
    double[, ] arr_2d = new double[row, col];
    for (int i = 0; i < row; i += 1)
    {
        for (int j = 0; j < col; j += 1)
        {           

            double cell = new Random().NextDouble() * (mx - mn) + mn;;
            arr_2d[i, j] = cell;
            Console.Write(string.Format("{0:f1}", cell) +";\t");

        }
        Console.WriteLine();
    }
    return arr_2d;
}


Console.WriteLine("Set the matrix size with Enter. ");
create_2d_array(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()));
