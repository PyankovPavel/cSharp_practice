// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

void isDivisible(int a, int b)
{
    bool isDiv = false;
    if (a % b == 0)
    {
        isDiv = true;
        Console.WriteLine(isDiv);
    }
    else
    {
        Console.WriteLine($"False, division surplus is {a % b}");
    }
}

isDivisible(25,5);
isDivisible(30,7);