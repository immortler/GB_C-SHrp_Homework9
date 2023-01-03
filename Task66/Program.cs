/* Задача 66: 
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30  */

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Error: wrong entry.");
        }
    }
    return result;
}

int SumOfElementsBetween(int m, int n, int sum)
{    
    if (n > m)
    {
        sum = sum + n;
        return SumOfElementsBetween(m, n - 1, sum);
    }
    else
    {
        return sum + m;
    }
}

int m = GetNumber("Enter first number (M):");
int n = GetNumber("Enter second number (N):");
Console.Write($"The sum of natural elements in the range from {m} to {n} is ");
if (m > n)
{
    (m, n) = (n, m);
}
int sum = SumOfElementsBetween(m, n, 0);
Console.Write($"{sum}.");