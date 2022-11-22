// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// (задача стоит в том, чтобы написать цикл)

Console.WriteLine("Введите число:");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень число:");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{Stepen(A, B)}");


// _____________________ Методы _____________________

int Stepen(int a, int b){
    int temp = a;
    for (int i = 0; i < b-1; i++)
    {
        a *= temp;
    }
    return a;
}

