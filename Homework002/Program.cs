/*Задача 50. Напишите программу, которая на вход 
принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет*/
using System;
using static System.Console;
Clear();
WriteLine("Enter 2 coordinates: ");
string[]coor = ReadLine().Split(" ");
int a = int.Parse(coor[0]);
int b = int.Parse(coor[1]);
int[,]array = GetArray(10,10);
WriteLine();
PrintArray(array);
WriteLine($"{GetNum}");
int[,] GetArray(int m, int n)
{
    int[,]res = new int[10,10];
    for(int i=0; i < m; i++)
    {
        for(int j=0; j<n; j++)
        {
            res[i,j]= new Random().Next(10, 100);
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
int GetNum(int [,] array,int a,int b)
{
    int x = 0;
    if (a >0 && a < array.GetLength(0) && b>0 && b < array.GetLength(1))
    {
        for(int i=0; i< array.GetLength(0);i++)
        {
            for(int j=0; j<array.GetLength(1);j++)
            {
            x = array[a,b];

            }
        }
    }
    else
    {
        WriteLine("No number");
    }
    return x;
}

