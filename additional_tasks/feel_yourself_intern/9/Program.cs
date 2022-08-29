//  9. Показать последнюю цифру трёхзначного числа

int lastNumber(int number)
{
    return number % 10;
}

Console.WriteLine(lastNumber(153));
Console.WriteLine(lastNumber(567));