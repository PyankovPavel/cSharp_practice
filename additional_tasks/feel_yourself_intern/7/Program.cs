// 7. Показать числа от -N до N

int[] showNumbers(int number)
{
    int[] array = new int[number * 2 + 1];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = number * -1;
        number--;
    }
    return array;
}

string str = String.Join(", ", showNumbers(5));
Console.WriteLine(str);
