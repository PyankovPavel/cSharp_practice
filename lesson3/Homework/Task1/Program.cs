// Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно
// палиндромом. Например, 14212 -> нет, 23432 -> да, 12821 -> да

Console.Write("Enter 5-digit number: ");
int a = int.Parse(Console.ReadLine());

void palindrom_check(int number)
{
    if (number > 99999 || number < 10000)
    {
        Console.WriteLine("Error. Write correct 5-digit number");
        return;
    }

    while (true)
    {
        if (number % 10 == number / 10000) // проверяем 1 и последнюю
        {
            if (number / 1000 % 10 == number % 100 / 10) // проверяем 2 и 4 числа
            {
                Console.WriteLine("Yes");
                return;
            }
            else
            {
                Console.WriteLine("No");
                return;
            }

        }
        else
        {
            Console.WriteLine("No");
            return;
        }
    }
}

palindrom_check(a);

