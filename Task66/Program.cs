﻿// Задача 66
// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
OutputNumbers(M, N);

void OutputNumbers(int M, int N)
{
  int[] array = {M, N};
  int sum = 0;
  for (int i = M; i <= N; i++)
  {
    sum = sum + i;
  }
  Console.WriteLine(sum);
}