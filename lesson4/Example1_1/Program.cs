// Задача 1: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// Например, 456 -> 3, 78 -> 2, 89126 -> 5

int CheckNumbers(int a)
{
    int count = 0;
    for (; a > 0;)
    {
        a = a/10;
        count++;
    }
    return count;
}

Console.WriteLine(CheckNumbers(78));