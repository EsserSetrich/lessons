/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/


void FillPrintArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = new Random().Next(1, 10);
            Console.Write(collection[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array = new int[3, 4];
FillPrintArray(array);

void SortElements(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            int num = collection[i, j];
            for (int k = 0; k < collection.GetLength(0) - 1; k++)
            {
                if (collection[i, k] < collection[i, k + 1])
                {
                    int temp = collection[i, k + 1];
                    collection[i, k + 1] = collection[i, k];
                    collection[i, k] = temp;
                    
                }
            }
        }
    }
}

SortElements(array);
Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
