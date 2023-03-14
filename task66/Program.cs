/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15-> 120
M = 4; N = 8. -> 30*/

int ReadInt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumFromMToN(int m, int n)
{
    if (n == m - 1) return 0;
    return n + SumFromMToN(m, n - 1);
}

int m = ReadInt("Inp number m");
int n = ReadInt("Inp number n");

if (m < n)
{
    Console.WriteLine(SumFromMToN(m, n));
}
else Console.WriteLine(SumFromMToN(n, m));
