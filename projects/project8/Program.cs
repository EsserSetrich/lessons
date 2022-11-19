// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

  Console.Write("Введите положительное число: ");
  int num = Convert.ToInt32(Console.ReadLine());
//int num = new Random(). Next(1, 100000);
//Console.WriteLine(num);
if(num <100)
 {
     Console.Write("третьей цифры нет");
 }
 else
 {
     while(num >=1000) 
     {
         num = num/10;
        // Console.WriteLine(num);
     }
     num = num%10;
         Console.WriteLine(num);
 }
