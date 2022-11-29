// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


Console.WriteLine("Введите длинну массива:");
int size = int.Parse(Console.ReadLine()!);

int[] array = GetArray(size);
Console.WriteLine($"Массив - [{String.Join(", ", array)}]");
Console.WriteLine($"Массив произведений - [{String.Join(", ", PairInArray(array))}]");

int[] PairInArray(int[] array){
    int l = array.Length, size = l/2;
    int[] array2;
    if (l % 2 == 0)
        array2 = new int[size];
    else{
        array2 = new int[(size + 1)];
        array2[size] = array[size];
    }
    for (int i = 0; i < size; i++,l--)
        array2[i] = array[i] * array[l-1];
    return array2;
}

int[] GetArray(int size, int minVal = 0, int maxVal = 10){
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minVal, maxVal);
    return array;
}
