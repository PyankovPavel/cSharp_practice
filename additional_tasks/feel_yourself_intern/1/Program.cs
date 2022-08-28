// 1. По двум заданным числам проверять является ли первое квадратом второго

bool isSquare(int a, int b)
{
    return a == b * b;
}

Console.WriteLine(isSquare(25, 5));
Console.WriteLine(isSquare(49, 7));
Console.WriteLine(isSquare(10, 3));