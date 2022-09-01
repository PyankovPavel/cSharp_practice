// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 

bool isWeekend(int number)
{
    bool flag = false;
    if (number > 7)
    {
        Console.Write("Input number from 1 to 7, ");
        return flag;
    }
    if (number > 0 && number < 6)
    {
        return flag;
    }
    else
    {
        return !flag;
    }
}

Console.WriteLine(isWeekend(5));
Console.WriteLine(isWeekend(6));
Console.WriteLine(isWeekend(10));
