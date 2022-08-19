// Задача 4: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8 

int exponent(int a, int b)
{
    if (b == 0) return 1;
    return exponent(a, b - 1) * a;
}

Console.WriteLine(exponent(2, 3));
Console.WriteLine(exponent(3, 5));