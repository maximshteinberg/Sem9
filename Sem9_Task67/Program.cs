// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


System.Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(SumNum(n, 0));


int SumNum(int num, int sum)
{
    sum += num % 10;
    if (num / 10 == 0)
    {
        return sum;
    }

    return SumNum(num / 10, sum);

}


// int Sum(int n)
// {
//     if (n == 0)
//     {
//         return 0;
//     }
//     return n % 10 + Sum(n / 10);
// }