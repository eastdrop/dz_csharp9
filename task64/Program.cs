/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

int ReadInt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int NumbersFromNToOne(int N, int i)
{

    if (N == i) return N;
    
    Console.Write(NumbersFromNToOne(N, i + 1) + " ");
    return i;

}
int i = 1;
Console.WriteLine(NumbersFromNToOne(ReadInt("Inp number"), i));
