// Задача 2: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// Например, 4 -> 24, 5 -> 120

int Fctorial(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= i;
    }
    return result;
}

Console.WriteLine(Fctorial(4));
Console.WriteLine(Fctorial(5));
Console.WriteLine(Fctorial(6));