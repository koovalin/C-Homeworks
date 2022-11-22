// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)

Console.WriteLine($"{String.Join(", ", FillArray(8))}");


// _____________________ Методы _____________________

int[] FillArray(int len, int limit = 1000)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(limit);
    }
    return array;
}



