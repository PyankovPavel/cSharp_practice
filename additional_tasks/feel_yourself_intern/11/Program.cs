// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int maxNumber()
{
    Random rnd = new Random();
    int number = rnd.Next(10, 100);
    Console.WriteLine(number);
    int max = number / 10;
    if (number % 10 > max)
    {
        max = number % 10;
    }
    return max;
}

Console.WriteLine(maxNumber());