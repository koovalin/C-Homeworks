// Задача 4
Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int num3 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Вы ввели числа {num1}, {num2}, {num3}.");

int max_num = num1;
if (max_num < num2) max_num = num2;
if (max_num < num3) max_num = num3;

Console.WriteLine($"Максимальное число = {max_num}");
