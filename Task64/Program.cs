// Задача 64
// Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
OutputNumbers(M, N);

void OutputNumbers(int M, int N)
{
  int[] array = {M, N};
  for (int i = M; i < N; i++)
  {
    Console.Write($"{i}, ");
  }
  Console.WriteLine();
}

// int n = InputNumbers("Введите n: ");
// int count = 2;
// PrintNumber(n, count);
// Console.Write(1);

// void PrintNumber(int n, int count)
// {
//   if (count > n) return;
//   PrintNumber(n, count + 1);
//   Console.Write(count + ", ");
// }

// int InputNumbers(string input) 
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }