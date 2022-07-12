int a = new Random().Next(10, 100);
Console.WriteLine(a);
int findMax(int a)
{
    int first = a / 10;
    int second = a % 10;
    int max = 0;
    if (first > second)
    {
        max = first;
    }
    else
    {
        max = second;
    }
    return max;
}

Console.WriteLine(findMax(a));
