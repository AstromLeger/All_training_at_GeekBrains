﻿// Задание 66 Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное число M"); 
int M = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите натуральное число N"); 
int N = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine(SummaRec(N)); 
 
int SummaRec(int N)
{
    if (M==N) return M;
    return N + SummaRec(N-1);
}
































































































