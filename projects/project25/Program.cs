/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
int numberline = 0;
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        int sum = 0;
        int minsum = 0;
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            sum += collection[i, j];
            if (sum <= minsum) sum = minsum;
            numberline = i;        
            
        }
    }   
    Console.Write($"Строка с минимальной суммой элементов равна {numberline}. ");     
}

SortElements(array);
Console.WriteLine();