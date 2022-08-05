// Задача 1: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//Например, 7 -> 28, 4 -> 10,  8 -> 36

int SumOfNumbers(int a)
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
    {
        sum += i;
    }
    return sum;
}
Console.WriteLine(SumOfNumbers(7));