/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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
            collection[i, j] = new Random().Next(1,10);
            Console.Write(collection[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int m = ReadInt("Задайте позицию элемента 1 размером: ") -1 ;
int n = ReadInt("Задайте позицию элемента 2 размером: ") -1;
double[,] array = new double[5, 5];

FillPrintArray(array);
if (m + 1 <= array.GetLength(0) || n + 1 <= array.GetLength(1) ) Console.Write(array[m, n]);
 else Console.WriteLine("Такого элемента нет ");