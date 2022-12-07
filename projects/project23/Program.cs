/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

void FillPrintArray(int[,] collection)
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

int[,] array = new int[5, 5];
FillPrintArray(array);


void ArithmeticMean(int[,] collection)
{
    double arithmeticMean =0;
    double sum =0;
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < collection.GetLength(1); j++)
    {
        for (int i = 0; i < collection.GetLength(0); i++)
        {
            collection[i, j] = new Random().Next(1,10);
            sum = sum + collection[i, j];
        }
        arithmeticMean = sum/collection.GetLength(0);
        Console.Write(arithmeticMean +"; ");
    }
}
ArithmeticMean(array);