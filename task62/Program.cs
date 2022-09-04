//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

using System;
class HelloWorld
{
    static void Main()
    {
        int x = 4;
        int[,] arr = new int[x, x];
        int right = x - 1, left = 0, top = 0, und = x - 1, sum = 1;
        for (int i = 0; i < x / 2 + x % 2; i++)
        {
            for (int t = left; t <= right; t++)
            {
                arr[top, t] = sum;
                sum++;
            }
            top++;
            for (int t = top; t <= und; t++)
            {
                arr[t, right] = sum;
                sum++;
            }
            right--;
            for (int t = right; t >= left; t--)
            {
                arr[und, t] = sum;
                sum++;
            }
            und--;
            for (int t = und; t >= top; t--)
            {
                arr[t, left] = sum;
                sum++;
            }
            left++;
        }
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < x; j++)
            {
                Console.Write($"{arr[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}