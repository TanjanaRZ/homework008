// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка
int m = 4;
int n = 4;
int[,] matrix = new int[m, n];
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write(matrix[i, j] + "   ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void MatrixSum(int[,] matrix)
{
    int min = 0, pos_min = 1;
    for (int i = 0; i < m;)
    {
        int sumM = matrix[i, 0];
        for (int j = 0; j < n - 1; j++)
        {
            sumM += matrix[i, j + 1];
        }
        if (i == 0)
        {
            min = sumM;
        }
        else if (sumM < min)
        {
            min = sumM;
            pos_min = i + 1;
        }
        i++;
    }
    Console.WriteLine("Строка с наименьшей суммой элементов:" + pos_min);
    Console.WriteLine();
}
PrintArray(matrix);
MatrixSum(matrix);
