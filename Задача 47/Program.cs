﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.Clear();

Console.WriteLine("Введите кол-во строк массива:");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите кол-во столбцов массива:");
int columns = int.Parse(Console.ReadLine()!);

double[,] array = GetArrayRandom(rows, columns, 0, 9);
PrintArrayDouble(array);
Console.WriteLine();


// ------------------------------ Method ----------------------------------

// Метод создания двумерного массива Random
double[,] GetArrayRandom(int m, int n, int minValue, int maxValue){
    double[,] result = new double[m, n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().NextDouble();
        }
    }
    return result;
}

// Метод печати массива
void PrintArrayDouble(double[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]:f2}".PadRight(6));
        }
    Console.WriteLine();
    }
}

