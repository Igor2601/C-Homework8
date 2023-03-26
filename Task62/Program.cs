// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
using System;
using static System.Console;
Clear();
Write($"Введите размер массива: ");
int s = int.Parse(ReadLine());
// Write($"Введите количество столбцов: ");
// int st = int.Parse(ReadLine());
int[,] arr = GetArray(s);
PrintArray(arr);
int[,] GetArray(int s)
{
    int[,] result = new int[s,s];
    int count = 1;
    int a = 1;
    int b = 1;
    for (int y = 0; y < s; y++)
        {
            result[0,y] = count;
            count++;
        }
        for (int x = 1; x < s; x++) {
            result[x,s - 1] = count;
            count++;
        }
        for (int y = s - 2; y >= 0; y--) {
            result[s - 1,y] = count;
            count++;
        }
        for (int x = s - 2; x > 0; x--) {
            result[x,0] = count;
            count++;
        }
        while (count < s * s)
        {
        while (result[a,b + 1] == 0)
            {
                result[a,b] = count;
                count++;
                b++;
            }
 
            while (result[a,b] == 0)
            {
                result[a,b] = count;
                count++;
                a++;
            }
 
            while (result[a,b - 1] == 0)
            {
                result[a,b] = count;
                count++;
                b--;
            }
 
        
            while (result[a - 1,b] == 0)
            {
                result[a,b] = count;
                count++;
                a--;
            }
        }
 
                for (int x = 0; x < s; x++)
            {
            for (int y = 0; y < s; y++)
             {
                if (result[x,y] == 0) {
                    result[x,y] = count;
                }
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