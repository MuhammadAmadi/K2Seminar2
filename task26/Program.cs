// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int inputNum()
{
    int count = 0;
    Console.WriteLine("Input number");
    string str = Convert.ToString(Console.ReadLine());
    if (str.All(Char.IsDigit))
    {
        count = str.Length;
    }
    return count;
}

void show(int count)
{
    Console.WriteLine(count);
}

show(inputNum());
