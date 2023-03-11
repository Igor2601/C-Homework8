// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
using System;
using static System.Console;
Clear();
int [,] array1 = GetArray(2, 2, 1, 9);
PrintArray(array1);
WriteLine();
int [,] array2 = GetArray(2, 2, 1, 9);
PrintArray(array2);
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
int [,] Production(int[,] array1,int[,] array2)
{
    int[,] array3 = new int[array1.GetLength(0),array1.GetLength(1)];
    int result = 0;
    for (int i = 0; i < array1.GetLength(0); i++)
    {
    for (int j = 0; j < array1.GetLength(1); j++)
    {
    for (int k = 0; k < array2.GetLength(1); k++)
    {    
        result += array1[i,k]*array2[k,j];        
    }    
    array3[i,j] = result;
    result = 0;
    }   
    }
    return array3;
}
WriteLine();
PrintArray(Production(array1,array2));

