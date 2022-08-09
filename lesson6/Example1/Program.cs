// Задача 1: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// *** Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

void checkTriangle(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
    {
        Console.WriteLine("Exist");
    }
    else
    {
        Console.WriteLine("Not exist");
    }
}

checkTriangle(5, 5, 5);
checkTriangle(11, 5, 5);
checkTriangle(1, 2, 3);
checkTriangle(4, 2, 5);