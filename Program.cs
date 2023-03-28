
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

/*
int[,] FillMatrixWithRandom(int row, int column)
{
int[,] array = new int[row, column];
Random rnd = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = rnd.Next(0, 10);
}
}
return array;
}

void PrintMatrix(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write($"{array[i,j]} \t");
}
Console.WriteLine();
}
}

void OrderArrayLines(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = 0; k < matrix.GetLength(1) - 1; k++)
      {
        if (matrix[i, k] < matrix[i, k + 1])
        {
          int number = matrix[i, k + 1];
          matrix[i, k + 1] = matrix[i, k];
          matrix[i, k] = number;
        }
      }
    }
  }
}
Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);
OrderArrayLines(matrix);
PrintMatrix(matrix);
*/


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*
int[,] FillMatrixWithRandom(int row, int column)
{
int[,] array = new int[row, column];
Random rnd = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = rnd.Next(0, 10);
}
}
return array;
}

void PrintMatrix(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write($"{array[i,j]} \t");
}
Console.WriteLine();
}
}

void SumDiag(int[,] matrix) 
{
 
int sum = 10;
int index = 0;
for (int i = 0; i <  matrix.GetLength(0); i++)
{
int number = 0;
for (int j = 0; j <  matrix.GetLength(1); j++)
{
number += matrix[i, j];
}
if (number < sum)
{
 sum = number;
index = i;
}
}
Console.WriteLine($"Строка под индексом: {index} , с наименьшей суммой элементов - {sum}");
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(1); i++)
{
Console.Write(matrix[index, i]+" ");
}
Console.ReadKey();  
}
Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(row, column); // это мы сами создали матрицу 
PrintMatrix(matrix);
SumDiag(matrix);
System.Console.WriteLine();
*/


// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

/*
int[,,] FillMatrixWithRandom(int row, int column, int depth)
{
int[,,] array = new int[row, column, depth];
Random rnd = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
  for (int k = 0; k < array.GetLength(2); k++)
{
array[i, j, k] = rnd.Next(0, 99);
}
}

}
return array;
}

void PrintMatrix(int[,,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
  for (int k = 0; k < array.GetLength(2); k++)
  {
    Console.Write($"{array[i,j,k]} \t");
}
}

Console.WriteLine();
}
}

void Portray3dArray(int[,,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
  for (int k = 0; k < array.GetLength(2); k++)
  {
    System.Console.Write("[" + i + "," + j + "," + k + "]" + array[i, j, k] + " ");
  }
  System.Console.WriteLine();
}
}
}


Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int depth = Convert.ToInt32(Console.ReadLine());
int[,,] matrix = FillMatrixWithRandom(row, column, depth);
PrintMatrix(matrix);
Portray3dArray(matrix);
System.Console.WriteLine();

*/








