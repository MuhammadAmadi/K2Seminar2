// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int Sum(int value)
{
    if(value < 10)
    {
        return value % 10;
    }
    int temp = value % 10;
    value = value/10;
    return temp + Sum(value);
}

Console.Write("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write(Sum(number));