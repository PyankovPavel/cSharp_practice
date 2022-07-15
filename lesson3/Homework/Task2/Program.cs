﻿// Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между
// ними в 3D пространстве. Например, A (3,6,8); B (2,1,-7), -> 15.84, A (7,-5, 0); B (1,-1,9) -> 11.53

double distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Round(Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2)), 2);
}

Console.WriteLine(distance(3, 6, 8, 2, 1, -7));
Console.WriteLine(distance(7, -5, 0, 1, -1, 9));