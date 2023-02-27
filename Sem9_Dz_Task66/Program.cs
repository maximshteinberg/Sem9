// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.Write("Введите число M: ");
int NumM = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число N: ");
int NumN = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(GetResult(NumM,NumN));

int GetResult(int m, int n)
{
    if (n<m)
       { return 0;}
    return n + GetResult(m, n - 1);
}