
/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
пример из 5 элементов:
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

получить все 8 чисел за одно нажатие Enter от пользователя.подсказка: использовать метод Split();*/


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] massiv8elements(int lenArray)
{
    int i = 0;
    int[] randomArray = new int[lenArray];
    while (i < randomArray.Length)
    {
        randomArray[i] = new Random().Next(1, 9);
        i++;
    }
    return randomArray;
}

int lenArray = ReadInt("Введите длинну массива: ");
int[] randomArray = massiv8elements(lenArray);
Console.WriteLine(string.Join(", ", randomArray));
