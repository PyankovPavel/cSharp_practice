// 12. Удалить вторую цифру трёхзначного числа

int[] deleteMiddleNumber(int number)
{
    int[] array = new int[2];
    array[0] = number / 100;
    array[1] = number % 10;
    return array;
}

string str = String.Join("", deleteMiddleNumber(123));
Console.WriteLine(str);
string str2 = String.Join("", deleteMiddleNumber(576));
Console.WriteLine(str2);