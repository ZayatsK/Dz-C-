/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

Console.WriteLine("Введите число");
string num = Console.ReadLine();
int numA = int.Parse(num);
int result = 0;

if(numA> 99 || numA<-99 )
{
    result = (numA%100)%10;
    Console.WriteLine(result);
}
if (numA<-999 || numA > 999)
{
    Console.WriteLine("третьей цифры нет");