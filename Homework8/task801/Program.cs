// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine ("введите количество строк и столбцов   ");
int row=Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("введите количество строк и столбцов   ");
int column=Convert.ToInt32(Console.ReadLine());


int [,] matrix=new int [row,column];
int [,] GetMatrix()
{
    for (int i = 0; i <matrix.GetLength(0); i++)
    {
        for (int j = 0; j <matrix.GetLength(1); j++)
        {
            matrix [i,j]=new Random().Next (1,10);
                     }
            }return matrix;
    }

void PrintMatrix(int [,] matrix)
{
     for (int i = 0; i <matrix.GetLength(0); i++)
    {
        for (int j = 0; j <matrix.GetLength(1); j++)
        {
            Console.Write(matrix [i,j]+",  ");
        }
        Console.WriteLine();
    }
}

PrintMatrix(GetMatrix());
Console.WriteLine("____________");

void ChangeMatrix (int [,] matrix)
{ 
int temp=0;

    for (int i = 0; i <matrix.GetLength(0); i++)
    {
        
        for (int k = 1; k <matrix.GetLength(1)-1; k++) //вводим доп переменную для перебора
        {
          for (int j = 0; j < matrix.GetLength(1)-k; j++)
          {
          
                  
            if (matrix[i,j]<matrix [i,j+1])
            {
                temp=matrix[i,j];
            matrix[i,j]=matrix [i,j+1];
            matrix[i,j+1]=temp;
            }
            
          }
                    }
            
                 }  
    }
    
ChangeMatrix(matrix);
PrintMatrix(matrix);




