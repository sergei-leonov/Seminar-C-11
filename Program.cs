//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
/*
double [,] FillarrayWithRandom(int row, int column)
{
double[,] array = new double[row, column];
Random rnd = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = rnd.NextDouble() +  rnd.Next(-10, 9 );

}
}
return array;
}

void Printarray(double[,] array)
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

Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
double[,] array = FillarrayWithRandom(row, column); // это мы сами создали матрицу 
Printarray(array);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

/*
int[,] FillarrayWithRandom(int row, int column)
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


Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillarrayWithRandom(row, column); 
PrintMatrix(matrix);
int elements = Convert.ToInt32(Console.ReadLine());

bool NumElements = false;

{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       for (int j = 0; j < matrix.GetLength(1); j++)
        {
if(elements == matrix [i,j])

NumElements = true;

}
}
if(NumElements)
{
System.Console.WriteLine("Такое число в массиве есть");
}
else
{
System.Console.WriteLine("Такого числа в массиве нет");
}
}
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/*
int[,] FillarrayWithRandom(int row, int column)
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

void Printarray(int[,] array)
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


 void SumDiag(int[,] array) 
{

for (int j = 0; j < array.GetLength(1); j++)

{
    double number = 0;
     for (int i = 0; i < array.GetLength(0) ; i++)
    {
       number = (number + array[i, j]);
    }
    number = number / array.GetLength(0);
    Console.Write(number +  "; ");
    
}
Console.WriteLine();
}


Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] array = FillarrayWithRandom(row, column); 
SumDiag(array);
System.Console.WriteLine();
Printarray(array);
*/







