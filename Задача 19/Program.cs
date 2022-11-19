﻿// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом(первое число равно последнему, второе равно предпоследнему).

Console.WriteLine("Введи 5-и значное число:");
int num = int.Parse(Console.ReadLine()!);
string s = num.ToString();

if (s.Length == 5)
{
    bool b = true;
    for (int i = 0; i < s.Length / 2; i++)
        if (s[i] != s[s.Length - i - 1])
            b = false;
    if (b == true)
        Console.WriteLine($"Число {num} полиндром!");
    else
        Console.WriteLine($"Число {num} не полиндром!");
}
else
    Console.WriteLine("Некорректное число!");


