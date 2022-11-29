// Задача 43: Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6) в промежутке от 0 до 100,
// а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).

int[] arr = GetArray(15, maxValue: 20);
// int[] arr = {5,6,3,9,7,5,1,9,2,6};

Console.WriteLine($"[{String.Join(", ", arr)}]");
Console.WriteLine($"[{String.Join(", ", SortArray(arr))}]");

int[] SortArray(int[] array){
    int l = array.Length, tmp, j;
    for (int i = 0; i < l; i++){;
        j = i;
        for (int k = i; k < l; k++)
            if (array[j] > array[k])
                j = k;
        tmp = array[i];
        array[i] = array[j];
        array[j] = tmp;
    }
    return array;
}

int[] GetArray(int size = 6, int minValue = 0, int maxValue = 10){
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue+1);
    return array;
}
