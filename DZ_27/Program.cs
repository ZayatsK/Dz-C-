/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

int SumNumbers(int n, int len, int sum)
{
    int i = 1;
    while (i <= len)
    {
        sum += n % 10;
        n /= 10;
        i++;
    }
    return sum;
}

int numA = ReadInt("Введите число: ");
int len = NumberLen(numA);
int sum = 0;
Console.WriteLine($"Сумма цифр в числе {numA} = {SumNumbers(numA, len, sum)}");
