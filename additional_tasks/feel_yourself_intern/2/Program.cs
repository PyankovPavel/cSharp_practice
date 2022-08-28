//  2. Даны два числа. Показать большее и меньшее число

int[] maxMin(int a, int b)
{
    int[] array = new int[2];
    if (a >= b)
    {
        array[0] = a;
        array[1] = b;
    }
    else
    {
        array[0] = b;
        array[1] = a;
    }
    return array;
}

string str = String.Join(", ", maxMin(2, 5));
Console.WriteLine(str);
string str1 = String.Join(", ", maxMin(100, 10));
Console.WriteLine(str1);
