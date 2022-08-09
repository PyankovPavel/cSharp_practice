// Задача 2: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 
// Например: 45 -> 101101, 3 -> 11, 2 -> 10

string transform(int a)
{
    String result = "";
    while (a > 0)
    {
        result = a % 2 + result;
        a /= 2;
    }
    return result;
}

Console.WriteLine(transform(12));



