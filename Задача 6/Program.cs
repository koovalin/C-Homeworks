// Задача 6

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);

if (num % 2 == 0)
{
    Console.WriteLine($"ДА. Число {num} делится на 2 без остатка!");
}
else
{
    Console.WriteLine($"НЕТ. Число {num} НЕ делится на 2 без остатка!");
}


