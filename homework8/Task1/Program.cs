void print_array(int[] array)
{
    for(int i = 0; i < array.Length; i ++)
    {
        Console.Write($"{array[i]}\t");
    }
    Console.WriteLine();
}

int[, ] create_matrix(int r, int c, int min, int max)
{
    int[, ] m = new int[r, c];
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            m[i, j] = new Random().Next(min, max+1);
            Console.Write($"{m[i,j]}\t");
        }
    Console.WriteLine();
    }
    Console.WriteLine();
    return m;
}

void sorted_rows(int[, ] matrix)
{
    (int rows, int columns) = (matrix.GetLength(0), matrix.GetLength(1));
    for (int i = 0; i < rows; i ++)
    {
        int[] res_arr = new int[columns];
        for (int j = 0; j < columns; j ++)
        {
            res_arr[j] = matrix[i, j];
        }
        Array.Sort(res_arr);
        Array.Reverse(res_arr);
        print_array(res_arr);

    }
}

Console.Write("Enter the number of rows: ");
int arg1 = Int32.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int arg2 = Int32.Parse(Console.ReadLine());
Console.Write("Enter the min number of matrix: ");
int arg3 = Int32.Parse(Console.ReadLine());
Console.Write("Enter the max number of matrix: ");
int arg4 = Int32.Parse(Console.ReadLine());
int[,] m1 = create_matrix(arg1, arg2, arg3, arg4);
sorted_rows(m1);
