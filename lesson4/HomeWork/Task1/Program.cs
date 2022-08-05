// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную
// степень B. 
// Например, 3, 5 -> 243 (3⁵), 2, 4 -> 16

int Exp(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result *= a;
    }
    return result;
}
Console.WriteLine(Exp(3, 5));
Console.WriteLine(Exp(2, 4));
Console.WriteLine(Exp(5, 5));


