// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Берем числа до 100000

Console.WriteLine("Введи число до 100_000:");
int numInt = int.Parse(Console.ReadLine()!);

if (numInt > 99 && numInt < 100000){
    string numStr = Convert.ToString(numInt);
    Console.WriteLine($"3-я цифра числа {numInt} = {numStr[2]}");
}
else if (numInt >= 100000)
    Console.WriteLine($"Число {numInt} не подходит!");
else
    Console.WriteLine($"В число {numInt} третьей цифры нет!");





