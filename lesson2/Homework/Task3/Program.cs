// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры
// нет. Например, 645 -> 5, 78 -> третьей цифры нет, 32679 -> 6

Console.Write("Enter a number: ");
int a = int.Parse(Console.ReadLine());

void findThirdNum(int number)
{
    int thirdNum = 0;
    if (number - 100 < 0)
    {
        Console.WriteLine("There's no 3d number");
    }
    else
    {
        while (number > 99)
        {
            if (number / 10 > 99)
            {
                number = number / 10;
            }
            else
            {
                thirdNum = number % 10;
                Console.WriteLine($"Third number is {thirdNum}");
                break;
            }
        }
    }
}

findThirdNum(a);

