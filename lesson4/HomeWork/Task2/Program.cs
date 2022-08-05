// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
// Например, 452 -> 11, 82 -> 10, 9012 -> 12

int sumOfNums(int a)
{
    int length = a.ToString().Length;
    int result = 0;
    for (int i = 0; i < length; i++)
    {
        result += (a % 10);
        a = a / 10;
    }
    return result;
}

Console.WriteLine(sumOfNums(452));
Console.WriteLine(sumOfNums(82));
Console.WriteLine(sumOfNums(9012));
Console.WriteLine(sumOfNums(5555));


