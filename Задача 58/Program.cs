Console.Clear();

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] array = GetArrayRandom(2,2);
int[,] array2 = GetArrayRandom(array.GetLength(0),array.GetLength(1));

PrintArray(array, "Массив 1:");
PrintArray(array2, "Массив 2:");
Console.WriteLine();
MultArrays(array,array2);

static void MultArrays(int[,] array, int[,] array2){
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++){;
        for (int j = 0; j < n; j++){
            result[i, j] = array[i, j] * array2[i,j];
        }
    }
    PrintArray(result, "Перемножение массивов:");
}


static void PrintArray(int[,] array, string str = "Массив:")
{
    Console.WriteLine(str);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j].ToString().PadRight(6));
        }
        Console.WriteLine();
    }
}

static int[,] GetArrayRandom(int m, int n, int minValue = 1, int maxValue = 10)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    return array;
}
