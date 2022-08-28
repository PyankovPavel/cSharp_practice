//  8. Показать четные числа от 1 до N

int[] showNumbers(int number)
{
    int[] array = new int[number / 2];
    int temp = 2;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = temp;
        temp += 2;
    }
    return array;
}

string str = String.Join(", ", showNumbers(20));
Console.WriteLine(str);
