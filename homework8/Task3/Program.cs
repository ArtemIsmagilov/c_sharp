// See https://aka.ms/new-console-template for more information
int[,] mul_matrixs(int [,] m1, int[,] m2)
{
    if (m1.GetLength(1) == m2.GetLength(0))
    {
        Console.WriteLine("Result -> ");
        int[,] res = new int[m1.GetLength(0), m2.GetLength(1)];
        for (int i = 0; i < m1.GetLength(0); i++)
        {
            for (int j = 0; j < m2.GetLength(1); j++)
            {
                for (int k = 0; k < m2.GetLength(0); k++)
                {
                    res[i,j] += m1[i,k] * m2[k,j];
                }
            }
            Console.WriteLine();
        }
        return res;
    }
    Console.WriteLine("Matrix not mul");
    return new int[0,0];
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

int[] parse_args()
{
    Console.Write("Enter the number of rows: ");
    int arg1 = Int32.Parse(Console.ReadLine());
    Console.Write("Enter the number of columns: ");
    int arg2 = Int32.Parse(Console.ReadLine());
    Console.Write("Enter the min number of matrix: ");
    int arg3 = Int32.Parse(Console.ReadLine());
    Console.Write("Enter the max number of matrix: ");
    int arg4 = Int32.Parse(Console.ReadLine());
    return new int[4] {arg1, arg2, arg3, arg4};
}

void print_matrix(int[,] m)
{
    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0; j < m.GetLength(1); j++)
        {
            Console.Write($"{m[i,j]}\t");
        }
        Console.WriteLine();
    }
}
int[] p1 = parse_args();
int[,] m1 = create_matrix(p1[0], p1[1], p1[2], p1[3]);
int[] p2 = parse_args();
int[,] m2 = create_matrix(p2[0], p2[1], p2[2], p2[3]);
print_matrix(mul_matrixs(m1, m2));
