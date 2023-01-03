/* Задача 68: 
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result >= 0)
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

int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if (n == 0 && m != 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
    }
}

int m = GetNumber("Enter the first argument (M):");
int n = GetNumber("Enter the second argument (N):");
Console.Write($"A({m},{n}) = ");
int result = AckermannFunction(m, n);
Console.Write($"{result}.");
