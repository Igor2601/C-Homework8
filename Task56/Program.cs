﻿// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
using System;
using static System.Console;
Clear();
int [,] array = GetArray(4, 4, 1, 9);
PrintArray(array);
WriteLine();
int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}
int RowsSum(int[,] array)
{
    int sum = 0;
    int[] result = new int[array.GetLength(0)];
    int minindex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i,j];     
    }  
        result[i] = sum;
        sum = 0;
        if (result[i] < result[minindex])
        {
        minindex = i;
        }   
    }
return minindex;
}
Write($"Номер строки с наименьшей суммой элементов: {RowsSum(array)+1} строка");