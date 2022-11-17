// Задача 8

Console.WriteLine("Введи положительное число: ");
int num = int.Parse(Console.ReadLine()!);

if (num<0) num = -num;
int count = 1;

while (count<=num)
{
    Console.Write($"{count}, ");
    count ++;
}