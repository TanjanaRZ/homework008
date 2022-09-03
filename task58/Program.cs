// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int m1 = 2; int n1 = 2; int m2 = 2; int n2 = 2; int m3 = 2; int n3 = 2;
int[,] matrix1 = new int[m1, n1];
int[,] matrix2 = new int[m2, n2];
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write(matrix[i, j] + "   ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
PrintArray(matrix1);
PrintArray(matrix2);
Console.WriteLine("Результирующая матрица:" );
int[,] matrixR = new int[m3, n3];
for (int i = 0; i < matrixR.GetLength(0); i++)
{
    for (int j = 0; j < matrixR.GetLength(1); j++)
    {
        matrixR[0, 0] = matrix1[0, 0] * matrix2[0, 0] + matrix1[0, 1] * matrix2[1, 0];
        matrixR[0, 1] = matrix1[0, 0] * matrix2[0, 1] + matrix1[0, 1] * matrix2[1, 1];
        matrixR[1, 0] = matrix1[1, 0] * matrix2[0, 0] + matrix1[1, 1] * matrix2[1, 0];
        matrixR[1, 1] = matrix1[1, 0] * matrix2[0, 1] + matrix1[1, 1] * matrix2[1, 1];
        Console.Write(matrixR[i, j] + "   ");
    }
    Console.WriteLine();
}
Console.WriteLine();

