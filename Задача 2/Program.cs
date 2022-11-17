//Задача №2


Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);

if (num1 == num2) Console.WriteLine("Числа равны!");
if (num1 > num2){
    Console.WriteLine($"Первое число {num1} больше второго числа {num2}");
}
else{
    Console.WriteLine($"Второе число {num2} больше первого числа {num1}");
}

