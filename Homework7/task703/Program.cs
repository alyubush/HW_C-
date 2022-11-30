﻿
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("введите кол-во строчек   ");
int rows=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите кол-во столбцов   ");
int columns=Convert.ToInt32(Console.ReadLine());

double average=0;


double [,] matrix=new double[rows,columns]; 
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j= 0; j < matrix.GetLength(1); j++)
    {
       matrix [i,j]=new Random().Next(0,12); 
       Console.Write(matrix[i,j]+"  "); 
    }
    Console.WriteLine ();
}


    
      for (int j = 0; j < matrix.GetLength(1); j++)
{
    double sum=0;
    for (int i= 0; i <matrix.GetLength(0) ; i++)
    {
       sum+=matrix [i,j];
              }
      average=Math.Round(sum/matrix.GetLength(0),2);
            Console.WriteLine ("средне арифметическое значение столбца "+j+" равно "+average);       
    }
   
   
       