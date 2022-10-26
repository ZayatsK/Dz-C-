/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Введите цифру дня недели");
string days = Console.ReadLine();
int day = int.Parse(days);


if (day == 6 || day == 7)
{
    Console.WriteLine("Выходной");
}
if (day > 0 && day < 6)
{
    Console.WriteLine("Рабочий день");
}
if (day < 1 || day > 7)
{
   Console.WriteLine("нет такого дня"); 
}


