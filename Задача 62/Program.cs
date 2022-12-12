class Program
{
    public static void Main()
    {
        Console.Clear();

        GetSpiralArray(5, 5);


        void GetSpiralArray(int m, int n)
        {
            int[,] result = new int[m, n];
            int move_row = 0, move_col = 1, x = 0, y = 0;

            for (int i = 1; i < m * n + 1; i++)
            {
                result[x, y] = i;
                int o = (x + move_row) % m, p = (y + move_col) % n;
                if (result[o, p] != 0)
                {
                    int tmp = move_row;
                    move_row = move_col;
                    move_col = -tmp;
                }
                Console.WriteLine($"{i} - {x} / {y} | {o}, {p} / {result[o, p]}");
                x += move_row;
                y += move_col;
            }

            PrintArray(result);
        }

        void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j].ToString().PadRight(6));
                }
                Console.WriteLine();
            }
        }
        Console.ReadLine();
    }
}