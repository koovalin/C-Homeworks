// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифор числа {num} = {SumNumbers(num)}");


// _____________________ Методы _____________________

int SumNumbers(int number)
{
    int n = 0, m = 0;
    while (number > 0)
    {
        n = number % 10;
        m += n;
        number /= 10;
    }
    return m;
}



