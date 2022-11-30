/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

void FillPrintArray(double[] collection)
{
    
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(-99,100);
        Console.Write(collection[i] + " ");
    }
}
double[] array = new double[10];

FillPrintArray(array);
Console.WriteLine();

void DifferentialMaxMinElem(double[] col2)
{
    double max = col2[0];
    double min = col2[0];
    for (int i = 0; i < col2.Length; i++)
        {
            if (col2[i] > max ) max = col2[i];
            if (col2[i] < min ) min = col2[i];
        }
    double diff = max - min;
    Console.WriteLine($"разницу между максимальным ({max}) и минимальным ({min}) элементов массива = ({diff}).");
}
DifferentialMaxMinElem(array);