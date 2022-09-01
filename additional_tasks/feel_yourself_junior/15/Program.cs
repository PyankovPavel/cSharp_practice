// 15. Дано число. Проверить кратно ли оно 7 и 23

bool isDivision(int number)
{
    return number % 7 == 0 && number % 23 == 0;
}

Console.WriteLine(isDivision(161));
Console.WriteLine(isDivision(210));
Console.WriteLine(isDivision(115));