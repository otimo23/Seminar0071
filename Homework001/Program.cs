/*Задайте двумерный массив размером m×n, заполненный 
случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9*/
Console.Clear();
Console.WriteLine("Enter rows number: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter columns number: ");
int n = int.Parse(Console.ReadLine()!);
double [,] array = GetArray(m,n);
PrintArray(array);

double [,] GetArray (int m, int n)
{
    double[,]res = new double[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j<n;j++)
        {
            res[i,j]= Convert.ToSingle(new Random().Next(-9, 10));
        }
    }
    return res;
}
void PrintArray(double [,] array)
{
    for(int i = 0; i<array.GetLength(0);i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            Console.Write(array [i,j]+"  ");
        }
        Console.WriteLine();
    }
    
}