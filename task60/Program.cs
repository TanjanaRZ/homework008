//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы 
//  каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
int x =2; int y = 2; int k = 2;
int[,,] matrixR = new int[x,y,k];
matrixR[0,0,0] = 66; 
matrixR[0,1,0] = 25;
matrixR[1,0,0] = 34; 
matrixR[1,1,0] = 41;
matrixR[0,0,1] = 27;
matrixR[0,1,1] = 90;
matrixR[1,0,1] = 26; 
matrixR[1,1,1] = 55;
  for (int i = 0; i < x; i++)
  {
    for (int j = 0; j < y; j++)
    { 
        for (int z = 0; z < k; z++)
        { 
        Console.Write($"   {matrixR[i, j, z]} {(i,j,z)}");
       }
       Console.WriteLine();
    }
}




