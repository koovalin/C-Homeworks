Console.Clear();

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] array = GetArrayRandom(2,2,2);
PrintArray(array, "Трехмерный массив с идексами:");
Console.WriteLine();


static void PrintArray(int[,,] array, string str = "Массив:")
{
    Console.WriteLine(str);
    for (int k = 0; k < array.GetLength(2); k++){    
        for (int i = 0; i < array.GetLength(0); i++){
            for (int j = 0; j < array.GetLength(1); j++){
                Console.Write($"{array[i, j, k]}({i},{j},{k})".ToString().PadRight(10));
            }
        Console.WriteLine();
        }
    }
}

static int[,,] GetArrayRandom(int m, int n, int b, int minValue = 10, int maxValue = 20)
{
    int[,,] array = new int[m, n, b];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            for (int k = 0; k < b; k++){
                array[i, j, k] = new Random().Next(minValue, maxValue + 1);
            }
        }    
    }
    return array;
}
