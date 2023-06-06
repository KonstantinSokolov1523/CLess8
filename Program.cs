Console.Write("Введите номер задачи(54,56,58,62): ");
int task = Convert.ToInt32(Console.ReadLine());
switch(task)
{
case 54:
    task54();
    break;
case 56:
    task56();
    break;
case 58:
    task58();
    break;
case 62:
    Task62();
    break;
default:
    Console.WriteLine("Такой задачи нет");
    break;
}
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
Console.WriteLine("Массив отсортирован: ");
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
int[,] array2d = new int[4,3];
int[] array = new int[4];
int mininarr = 0;
Randarr2d(array2d);
PrintArr2d(array2d);
SumInArr(array2d, array);
Console.WriteLine();
mininarr = FindMininArr(array, mininarr);
Console.WriteLine($"минимальная сумма значений в строке № {mininarr + 1}");
}

/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

void task58()
{
int[,] array1 = new int[2, 2];
Randarr2d(array1);
Console.WriteLine("Матрица 1: ");
PrintArr2d(array1);
int[,] array2 = new int[2,2];
Randarr2d(array2);
Console.WriteLine("Матрица 2: ");
PrintArr2d(array2);
int[,] promatrix = new int[2,2];
ProMatrix(array1, array2, promatrix);
Console.WriteLine("Результат умножения матриц: ");
PrintArr2d(promatrix);
}

/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */
void Task62()
{
int[,] array2d = new int[4,4];
    FillingArr2d(array2d);
    PrintArr62(array2d);
}

//склад методов

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

void SumInArr(int[,] array2d, int[] array)
{
    
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        int Sum = 0;
        for (int j = 0; j < array2d.GetLength(1); j++)
        { 
            Sum += array2d[i,j];
            array[i] = Sum;
        }
    }
}


int FindMininArr(int[] array, int min)
{
    min = 0;
    for(int i = 0; i <= array.Length-1; i++)
    {
        if(array[i] < array[min])
        {
            min = i;
        }
    
    }
    return min;
}


void PrintArr62(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}

void FillingArr2d(int[,] array)
{
    int tmp = 1;
    int i = 0;
    int j = 0;
    while (tmp <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = tmp;
        tmp++;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= array.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > array.GetLength(1) - 1)
            j--;
        else
        i--;
    }
}
int[,] ProMatrix(int[,] array1, int[,] array2, int[,]promatrix)
{
for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    for (int x = 0; x < array2.GetLength(0); x++)
                    {
                        promatrix[i,j] += array1[i,x] * array2[x,j];
                    }
                }
            }
return promatrix;
}