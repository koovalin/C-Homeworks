Console.Clear();

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] array = GetArrayRandom(5,6);
PrintArray(array);
Console.WriteLine();
SortArray(array);

static void SortArray(int[,] array){
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    for (int i = 0; i < m; i++){;
        for (int j = 0; j < n; j++){
            for (int k = j+1; k < n; k++){
                if (array[i,j] < array[i,k]){
                    int tmp = array[i,j];
                    array[i,j] = array[i,k];
                    array[i,k] = tmp;
                }
            }
        }
    }
    PrintArray(array, "Сортированный массив:");
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

static int[,] GetArrayRandom(int m, int n, int minValue = 0, int maxValue = 9)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    return array;
}