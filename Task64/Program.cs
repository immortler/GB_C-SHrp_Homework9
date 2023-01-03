/* Задача 64: 
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"  */


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

void FinalCountdown(int number)
{    
    if (number >1)
    {
        Console.Write($"{number}, ");
        FinalCountdown(number-1);
    }
    else
    {
        Console.Write($"{number}.");
        Console.WriteLine();
        return;
    }
}

int number = GetNumber("Enter a number:");

FinalCountdown(number);