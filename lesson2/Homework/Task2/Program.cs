// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру
// этого числа. Например, 456 -> 46, 782 -> 72, 918 -> 98

int a = new Random().Next(100, 1000);
Console.WriteLine($"Generated number is {a}");

void deleteSecNum(int a)
{
    int first = a / 100;
    int third = a % 10;
    Console.WriteLine($"Answer is {first}{third}");
}

deleteSecNum(a);

