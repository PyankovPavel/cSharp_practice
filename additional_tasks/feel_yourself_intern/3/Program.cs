// 3. По заданному номеру дня недели вывести его название

string dayName(int n)
{
    switch (n)
    {
        case 1:
            return "Monday";
        case 2:
            return "Tuesday";
        case 3:
            return "Wednsday";
        case 4:
            return "Thursday";
        case 5:
            return "Friday";
        case 6:
            return "Saturday";
        case 7:
            return "Sunday";
        default:
            return "Enter number from 1 to 7";
    }
}

Console.WriteLine(dayName(5));
Console.WriteLine(dayName(2));
Console.WriteLine(dayName(15));