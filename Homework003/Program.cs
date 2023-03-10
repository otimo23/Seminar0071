/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

using System;
using static System.Console;
Clear();
int[,]array = GetArray(3,3);
WriteLine();
PrintArray(array);
WriteLine();
GetAv(array);
int[,] GetArray(int m, int n)
{
    int[,]res = new int[3,3];
    for(int i=0; i < m; i++)
    {
        for(int j=0; j<n; j++)
        {
            res[i,j]= new Random().Next(1, 10);
        }
    }
    return res;
}
void PrintArray(int [,] Inarray)
{
for (int i=0; i< Inarray.GetLength(0); i++)
{
    for(int j=0; j < Inarray.GetLength(1);j++)
    {
        Write(Inarray[i,j] + " ");
    }
    WriteLine();
}
}


void GetAv(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        {
        int av = 0;
        int sum =0;
        for(int j = 0; j < array.GetLength(1); j++)
            {
                sum = (sum + array[i, j]);
            }
                av = sum / array.GetLength(0);
                Console.WriteLine($"Av in a row = {av} ");
        }
}
