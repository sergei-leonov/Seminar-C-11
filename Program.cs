﻿//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет
//12821 -> да                    
//23432 -> да  
/*    
int Prompt (string message)
{
Console.Write(message);
int resault = Convert.ToInt32 (Console.ReadLine());
return resault;
}

int number = Prompt("Введите число");

int first = number % 10;            
int second = number / 10000;
if (second == first)

      Console.WriteLine("is a palindrome!");
else
      Console.WriteLine("is not a palindrome!");
*/


//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53
/*
double Distance3D(double x1, double y1, double z1,  double x2, double y2,double z2)
{
double res = Math.Sqrt(Math.Pow(x2 - x1 ,2) + Math.Pow(y2 - y1, 2)+ Math.Pow(z2 - z1, 2));
return Math.Round(res, 2);
}

Console.Write("Введите координату по Х для первой точки ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по У для первой точки ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по У для первой точки ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по Х для второй точки ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по Y для второй точки ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по У для первой точки ");
double z2 = Convert.ToDouble(Console.ReadLine());

double distance = Distance3D(x1, y1, z1, x2, y2, z2);
System.Console.WriteLine($"Расстояние между точками = {distance}");
*/


//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
/*
int Prompt (string message)
{
Console.Write(message);
int resault = Convert.ToInt32 (Console.ReadLine());
return resault;
}

int number = Prompt("Введите число > ");
for(int i = 1; i <= number; i++)  

{
Console.Write($"{Math.Pow(i, 3)} ");       
}
*/

