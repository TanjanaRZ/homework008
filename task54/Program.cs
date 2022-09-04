// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
int m = 3;
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
void MatrixLines(int[,] matrix)
{
    for (int i = 0; i < m;)
    {
        int b = 1;
        for (int j = 1; j < n; j++)
        {

    
            if (matrix[i, j] > matrix[i, j - 1])
            {
                int temp = matrix[i, j - 1];
                matrix[i, j - 1] = matrix[i, j];
                matrix[i, j] = temp;
                b = 0;
            }

        }
        if (b == 1)
        {
            i++;
        }
    }
}
void PrintArray1(int[,] matrix)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {

            Console.Write(matrix[i, j] + "   ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

PrintArray(matrix);
MatrixLines(matrix);
PrintArray1(matrix);



