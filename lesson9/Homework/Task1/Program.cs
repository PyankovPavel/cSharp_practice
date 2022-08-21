// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

void printNums(int m, int n)
{
    if (m > n)
    {
        return;
    }
    if (m % 2 == 0)
    {
        printNums(m, n - 2);
        Console.WriteLine($"{n}");
    }
    else if(n > m)
    {
        n--;
        printNums(m, n - 1);
        Console.WriteLine($"{n}");
    }
}

printNums(1, 5);
Console.WriteLine();
printNums(4, 8);
Console.WriteLine();
printNums(1, 15);
