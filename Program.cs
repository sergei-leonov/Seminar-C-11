//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 //Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

/*
int[] FillArrayWhithRandomNumber(int size)
{
int[] arr = new int[size];
Random rnd = new Random();
for(int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(100, 999);
}
return arr;
}

System.Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWhithRandomNumber(size);
System.Console.Write($"[{string.Join(", ", array)}] -> ");

int count = 0;
for(int i = 0; i < array.Length; i++)
{
if( array[i] % 2 == 0)
{
count++;
}
}
System.Console.WriteLine(count);
*/


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

/*
int[] FillArrayWhithRandomNumber(int size)
{
int[] arr = new int[size];
Random rnd = new Random();
for(int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(1, 10);
}
return arr;
}

System.Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWhithRandomNumber(size);
System.Console.Write($"[{string.Join(", ", array)}] -> ");   

int sum = 0;
for (int i = 0; i < array.Length; i++)
if (i % 2 != 0)
{
    sum = sum + array[i];
}
else
{
    array[i]= 0;
}
Console.Write(sum);
*/



//Задача 38: Задайте массив вещественных чисел(тип double). 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3,1; 7,2; 22,3; 2,4; 78,5] -> 76,1
/*
Console.WriteLine("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
FillArrayRandomNumbers(array);
PrintArray(array);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }
}

Console.WriteLine($" {max - min}");

void FillArrayRandomNumbers(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " " );
        }
    Console.Write("]"+ "->");
   
   }
   */