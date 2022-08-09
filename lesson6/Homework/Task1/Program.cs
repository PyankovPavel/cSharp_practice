// Задача 1: Пользователь вводит с клавиатуры m чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Например:
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int attempts = 0; // попытки ввода
int count = 0; // считаем числа > 0

Console.WriteLine("Input numbers");
while (attempts < 5)
{
    string s = Console.ReadLine();
    if (int.TryParse(s, out int num))
    {
        if (num > 0)
        {
            count++;
        }
    }
    else
    {
        Console.WriteLine("Error. Please run again & input numbers only");
        break;
    }
    attempts++;
}

Console.WriteLine($"Numbers > 0: {count}");

