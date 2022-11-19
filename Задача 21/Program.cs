// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// float[] mas = {3, 6, 8, 2, 1, -7};
float[] mas = {7, -5, 0, 1, -1, 9};

float x1 = mas[0];
float y1 = mas[1];
float z1 = mas[2]; 
float x2 = mas[3];
float y2 = mas[4];
float z2 = mas[5];

double dist = Math.Pow((Math.Pow(x2 - x1, 2) +
                Math.Pow(y2 - y1, 2) +
                Math.Pow(z2 - z1, 2) * 1.0), 0.5);
Console.WriteLine($"Растояние между точками: {dist:f2}");




