// 10. Показать вторую цифру трёхзначного числа

int middleNumber(int number)
{
    return number / 10 % 10;
}

Console.WriteLine(middleNumber(153));
Console.WriteLine(middleNumber(567));