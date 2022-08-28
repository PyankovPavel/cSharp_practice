// 4. Найти максимальное из трех чисел

int Max(int a, int b, int c)
{
    int max = a;
    if (b > a && b > c)
    {
        max = b;
    }
    else if (c > a && c > b)
    {
        max = c;
    }
    return max;
}

Console.WriteLine(Max(1, 2, 3));
Console.WriteLine(Max(4, 1, 5));
Console.WriteLine(Max(10, 20, 3));