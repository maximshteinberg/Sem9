﻿// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

System.Console.Write("Введите число A: ");
int NumA = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число B: ");
int NumB = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Res(NumA,NumB));


int Res(int a, int b)
{
    if (b==0)
    {
        return 1;
    }
    return a * Res(a,b-1);
}