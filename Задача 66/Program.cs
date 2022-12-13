// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


class Program
{
    static int SumElem(int start, int end)
    {
        if (start > end){
            int tmp = start;
            start = end;
            end = tmp;
        }
        if (start == end) return start;
        return (start + SumElem(start + 1, end));
    }

    static void Main(string[] args)
    {
        Console.Write("Введите M: ");
        int M = int.Parse(Console.ReadLine()!);
        Console.Write("Введите N: ");
        int N = int.Parse(Console.ReadLine()!);
        Console.WriteLine(SumElem(M, N));
    }
}