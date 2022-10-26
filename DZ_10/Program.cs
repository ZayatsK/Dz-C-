/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

Console.WriteLine("Введите трехзначное число");
string num = Console.ReadLine();
int numA = int.Parse(num);
int result = 0;

if (numA<1000 && numA> 99)
{
    result = (numA%100)/10;
    Console.WriteLine(result);
}

if (numA<-99 && numA> -1000)
{
    result = (numA%100)/10;
    Console.WriteLine(result);
}
if (numA<-999 || numA > 999)
{
    Console.WriteLine("Ввели неверное число");
}