﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Обязательна проверка на ввод чисел больше/меньше 3-х знаков
// Var 1

Console.WriteLine("Введи 3-х значное число:");
int numInt = int.Parse(Console.ReadLine()!);
string numStr = Convert.ToString(numInt);

if (numStr.Length != 3)
    {
        Console.WriteLine("Введено некорректное число!");
    }
else
{
    Console.WriteLine(numStr[1]);
}