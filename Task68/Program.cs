// Задача 68
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
FunctionAckermann(m, n);
PrintResult(m, n);

int FunctionAckermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return FunctionAckermann(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return FunctionAckermann(m - 1, FunctionAckermann(m, n - 1));
    }
    else
        return n + 1;
}

void PrintResult(int m, int n)
{
Console.WriteLine(FunctionAckermann(m, n));
}
