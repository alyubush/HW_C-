// SeЗадача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine ("введите количество строк и столбцов   ");
int row=Convert.ToInt32(Console.ReadLine());
int column=row;

int [,] GetMatrix()
{
    int [,] matrix=new int [row,column];
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
int [,] matrix1 = GetMatrix();
PrintMatrix(matrix1);
Console.WriteLine("___________");
int [,] matrix2 = GetMatrix();
PrintMatrix(matrix2);
Console.WriteLine("___________");

int [,] matrix3=new int [row,column];
 
 for (int i = 0; i <matrix3.GetLength(0); i++)
    {
        for (int j = 0; j <matrix3.GetLength(1); j++)
        {
           int sum=0;
           for (int k = 0; k <matrix1.GetLength(0); k++)
           {
            sum+=matrix1[i,k]*matrix2[k,j];
           }
            Console.Write((matrix3[i,j]=sum)+" ");
            
         }
    Console.WriteLine();
    }