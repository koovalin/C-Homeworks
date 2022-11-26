// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях(индексы элементов должны быть нечетными(1,3,5 и тд)).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] array = {-4, -6, 89, 6};
int[] array = GetArray(6);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"[{String.Join(", ", OddIndexSum(array))}]");


int OddIndexSum(int[] array)
{

    if (array.Length > 1)
    {
        int sum = array[1];
        for (int i = 3; i < array.Length; i += 2)
        {
            sum += array[i];
        }
        return sum;
    }
    else
    {
        return 0;
    }
}


int[] GetArray(int size, int minVal = -10, int maxVal = 10)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minVal, maxVal);
    }
    return array;
}