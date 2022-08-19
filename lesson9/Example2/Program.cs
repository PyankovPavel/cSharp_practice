// Задача 2: Задайте значения M и N. Напишите программу, которая рекурсивно выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8" 

void Values(int min, int max)
{
    if (max < min) return;
    Values(min, max-1);
    Console.Write($"{max}, ");
}

Values(1, 5);