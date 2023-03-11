// Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
using System;
using static System.Console;
Clear();
WriteLine($"Введите размер массива X x Y x Z: ");
int x = InputNumbers("Введите X: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");
WriteLine();
int[,,] array3D = GetArray(x, y, z, 10, 100);
PrintArray(array3D);
int InputNumbers(string input)
{
  Write(input);
  int output = Convert.ToInt32(ReadLine());
  return output;
}
int[,,] GetArray(int x, int y, int z, int min, int max)
{
    int[,,] result = new int[x, y, z];
        for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
            result[i, j, k] = new Random().Next(min, max + 1);
            }
        }
    }
    return result;
}
void PrintArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
    for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Write( $"{array3D[i,j,k]}({i},{j},{k}) ");
      }
    WriteLine();
    }
  }
}
