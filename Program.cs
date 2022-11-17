/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int GetNumber(string message)
{
    int result = 0;
    bool isCorrect = false;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result != 0)
            isCorrect = true;
        else
            Console.WriteLine("Вы ввели не число!\n");
    }

    return result;
}

int SumElements(int m, int n)
{
    if (n == m) return m;
    else return n + SumElements(m, n - 1);
}


int m = GetNumber("Введите натуральное число M");
int n = GetNumber("Введите натуральное число N");
if (n > m)
{
    Console.WriteLine($"Cумма натуральных элементов в промежутке от {m} до {n} равна: {SumElements(m, n)}");
}
else
{
    Console.WriteLine($"Cумма натуральных элементов в промежутке от {n} до {m} равна: {SumElements(n, m)}");
}

