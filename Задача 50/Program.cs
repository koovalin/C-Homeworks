// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 5; j = 2 -> такого числа в массиве нет
// i = 1; j = 1 -> 9

Console.Clear();

// Console.WriteLine("Введите кол-во строк массива:");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите кол-во столбцов массива:");
// int columns = int.Parse(Console.ReadLine()!);

int rows = 6;
int columns = 6;

Console.WriteLine("Номер строки:");
int i = int.Parse(Console.ReadLine()!);
Console.WriteLine("Номер столбца:");
int j = int.Parse(Console.ReadLine()!);
Console.WriteLine();


int[,] array = GetArrayRandom(rows, columns, 1, 9);

PrintArray(array);
Console.WriteLine();
FindValue(array,i,j);
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
    for(int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j].ToString().PadRight(6));
        }
    Console.WriteLine();
    }
}

void FindValue(int[,] result, int i, int j){
    if (i > result.GetLength(0) || j > result.GetLength(1))
        Console.WriteLine("Такого числа в массиве нет!");
    else Console.WriteLine($"Найдено число - {result[i-1,j-1]}");
}