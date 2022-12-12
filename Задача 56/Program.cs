Console.Clear();

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array = GetArrayRandom(8,5);
PrintArray(array);
Console.WriteLine();
FindStringArray(array);

static void FindStringArray(int[,] array){
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    int[] result = new int[n];
    int sum = 0, str = 1;

    for (int j = 0; j < n; j++){
        sum += array[0, j];
    }

    for (int i = 1; i < m; i++){
        int tmpSum = 0;
        for (int j = 0; j < n; j++){
            tmpSum += array[i, j];
        }
        if (tmpSum < sum){
            sum = tmpSum;
            str = i;
        }
    }

    for (int j = 0; j < n; j++){
        result[j] = array[str, j];
    }
    Console.WriteLine($"Строка в двумерном массиве с наименьшей суммой - {str+1}\nМассив:\n{String.Join("".PadRight(5),result)}");
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

static int[,] GetArrayRandom(int m, int n, int minValue = 0, int maxValue = 10)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    return array;
}
