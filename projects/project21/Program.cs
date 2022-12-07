/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}



void FillPrintArray(double[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = new Random().Next(1, 100)/10.0;
            Console.Write(collection[i, j] + " ");
        }
        Console.WriteLine();
    }
}


int m = ReadInt("Задайте двумерный массив 1 размером: ");
int n = ReadInt("Задайте двумерный массив 2 размером: ");
double[,] array = new double[m, n];
FillPrintArray(array);
