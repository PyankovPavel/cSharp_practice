// 14. Найти третью цифру числа или сообщить, что её нет

int thirdNumber(int number)
{
    int size = 1;
    int temp = number;
    while (temp / 10 > 0)
    {
        temp /= 10;
        size++;
    }
    int[] array = new int[size];
    int division = 1;
    for (int i = 1; i < size; i++)
    {
        division *= 10;
    }
    for (int j = 0; j < array.Length; j++)
    {
        array[j] = number / division;
        number %= division;
        division /= 10;

    }
    if (size > 2)
    {
        return array[2];
    }
    else
    {
        Console.Write("No third number in input data. Error ");
        return 404;
    }

}

Console.WriteLine(thirdNumber(1234));
Console.WriteLine(thirdNumber(10));

