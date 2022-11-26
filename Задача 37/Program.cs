// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


//                0  1  2  3  4  5  6
// int[] array = {1, 2, 3, 4, 5, 6, 7};

int[] array = GetArray(5);

Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"[{String.Join(", ", PairInArray(array))}]");

int[] PairInArray(int[] array){
    int size = 0;
    if (array.Length % 2 == 0)
        size = array.Length / 2;
    else
        size = (array.Length / 2) + 1;
    int[] array2 = new int[size];
    array2[size-1] = array[array.Length / 2 + 1];

    for (int i = 0; i < size; i++){
        if (i != array.Length - i - 1)
            array2[i] = array[i] + array[array.Length - i - 1];
        else
            array2[i] = array[i];
    }
    return array2;
}

int[] GetArray(int size, int minVal = 0, int maxVal = 10)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minVal, maxVal);
    }
    return array;
}