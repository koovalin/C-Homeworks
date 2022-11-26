// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = GetArray(10);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"В Массиве {PositivCounter(array)} положительных чисел");

int PositivCounter(int[] array){
    int c = 0;
    foreach (int i in array)
    {
        if (i % 2 == 0) c++;
    }
    return c;
}

int[] GetArray(int size, int minVal = 100, int maxVal = 1000)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minVal, maxVal);
    }
    return array;
}

