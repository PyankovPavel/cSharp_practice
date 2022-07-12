// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным. Например, 6 -> да, 7 -> да, 1 -> нет

Console.Write("Enter a day number of the week: ");
int dayNumber = int.Parse(Console.ReadLine());

void check(int number)
{
    if (number > 7 || number <= 0)
    {
        Console.WriteLine("Error. The week has 7 days");
    }
    else if (number == 6 || number == 7)
    {
        Console.WriteLine("Yes, it's day off");
    }
    else
    {
        Console.WriteLine("No, it's working day");
    }
}

check(dayNumber);
