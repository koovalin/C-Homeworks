// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

int count = new Random().Next(6,15);
Console.WriteLine(count);
KeyInput(count);

void KeyInput(int c)
{
    int temp, count = 0;
    for (int i = 0; i < c; i++){
        temp = new Random().Next(-10,10);
        Console.Write($"{temp} ");
        if (temp > 0) count++;
    }
    Console.WriteLine($"\nПользователь ввел число больше нуля {count} раз!");
}



