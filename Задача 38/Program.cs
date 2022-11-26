// Задача 38: Задайте массив целых чисел от -10 до 10. Найдите разницу между максимальным и минимальным элементов массива.

int[] array = GetArray(8);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"Разница между минимальным и максимальным числом массива = {MinMaxDif(array)}");


int MinMaxDif(int[] array)
{
    int min = array[0], max = array[0];
    foreach(int i in array)
    {
        if(i < min) min = i;
        if(i > max) max = i;
    }
    return max - min;
}

int[] GetArray(int size, int minVal = -10, int maxVal = 11)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minVal, maxVal);
    }
    return array;
}