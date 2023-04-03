// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
void NumNat ( int n)
{
if (n == 0)
    {
        return;
    }
    
    Console.Write($"{n} ");
    NumNat(n - 1);
}


System.Console.WriteLine("Введите число : ");
int n = Convert.ToInt32(System.Console.ReadLine());
NumNat (n);
*/


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/*
System.Console.WriteLine("Введите число : ");
int M = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите число : ");
int N = Convert.ToInt32(System.Console.ReadLine());


void GapNumberSum (int M, int N, int sum)
{
    if (M > N) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");

        return;
    }
    sum = sum + (M++);
    GapNumberSum(M, N, sum);
}

GapNumberSum(M, N, 0);
*/


//System.Console.WriteLine(GapNumberSum (M, N));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

/*
System.Console.WriteLine("Введите число : ");
int m = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите число : ");
int n = Convert.ToInt32(System.Console.ReadLine());
AkkermanFunction(m,n);

void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}
*/