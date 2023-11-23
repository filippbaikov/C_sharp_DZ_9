Console.Clear();

System.Console.Write("введи число: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(recTusk64(n, 1));
System.Console.WriteLine();
System.Console.Write("введи M число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("введи N число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(recTusk66(num1,num2));

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int recTusk64(int n, int m)
{
    if (n == m) return n;
    else Console.Write($"{recTusk64(n, m + 1)}, ");
    return m;
}


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int recTusk66(int n, int m)
{
    if (n == m) return n;
    else
        return recTusk66(n + 1, m) + n; ;
}

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// не понял как делать