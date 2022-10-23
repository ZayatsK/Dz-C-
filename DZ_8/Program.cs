/*адача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.WriteLine("Введите число");
string numAstr = Console.ReadLine();
int numA = int.Parse(numAstr);

if (numA <= 1)
    {
        Console.WriteLine("Введите число больше 1");
    }

for (int i = 1; i <= numA; i++)
{
    if (i%2==0)
    {
        Console.WriteLine(i);
    }
    
    
}