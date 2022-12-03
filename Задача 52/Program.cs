// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

Console.WriteLine("Введите кол-во строк массива:");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите кол-во столбцов массива:");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int[,] array = GetArrayRandom(rows, columns, 0, 9);
PrintArray(array);
Console.WriteLine();
GetAvgSumCol(array);
Console.WriteLine();


// ------------------------------ Method ----------------------------------

// Метод создания двумерного массива Random
int[,] GetArrayRandom(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return result;
}

// Метод печати массива
void PrintArray(int[,] array){
    Console.WriteLine("Массива:");
    for(int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j].ToString().PadRight(6));
        }
    Console.WriteLine();
    }
}

void GetAvgSumCol(int[,] result){
    int m = result.GetLength(0);
    int n = result.GetLength(1);

    float[] mas = new float[n];
    for(int j = 0; j < n; j++){
        for(int i = 0; i < m; i++){
            mas[j] += result[i,j];
        }
        mas[j] /= n;
    }
    Console.WriteLine("Среднее арифметическое:");
    PrintArrayFloat(mas);
}

// Метод печати массива типа float
void PrintArrayFloat(float[] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]:f1}".PadRight(6));
    }
    Console.WriteLine();
}


