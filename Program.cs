/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */
void task54()
{
int[,] array2d = new int [4,3];
Randarr2d(array2d);
PrintArr2d(array2d);
console.WriteLine("Массив отсортирован: ");
SortArr2d(array2d);
PrintArr2d(array2d);
}
  




/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7



Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

void task56()
{
int[,] array2d = new int[4];
int[] array = new int[4, 4];
Randarr2d(array2d);
SumInArr(array2d, array)


/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

void Randarr2d(int[,] array) 
 { 
     for (int i = 0; i < array.GetLength(0); i++) 
     { 
         for (int j = 0; j < array.GetLength(1); j++) 
         { 
             array[i, j] = new Random().Next(0, 10); 
         } 
     } 
 }

void PrintArr2d(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}

void SortArr2d(int[,] array)
{
for (int i =0; i<array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
for(int x = 0; x < array.GetLength(1)-1; x++)
{
if (array[i, x] < array[i, x + 1])
{
int tmp = array[i, x + 1];
array[i, x + 1] = array[i, x];
array[i, x] = tmp;
}
}
}
}
}

void SumInArr(int[,] array2d, int[array])
{
for (int i = 0; i < array2d.GetLength(0); i++)
{
for (int j = 0; j < array2d.GetLength(1); j++)
{ 
int Sum = 0;
Sum += array2d[i,j];
array[i] = Sum;
}
}
}