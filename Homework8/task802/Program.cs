// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.WriteLine ("введите количество строк и столбцов   ");
int row=Convert.ToInt32(Console.ReadLine());


int [,] matrix=new int [row,row];

    for (int i = 0; i <matrix.GetLength(0); i++)
    {
        for (int j = 0; j <matrix.GetLength(1); j++)
        {
            matrix [i,j]=new Random().Next (1,10);
             Console.Write(matrix [i,j]+",  ");
        }
        Console.WriteLine();
    }
 int [] sum=new int [row];
 
   for (int i = 0; i <matrix.GetLength(0); i++)
    {
               sum [i]=0;
               for (int j = 0; j <matrix.GetLength(1); j++)
        {
            sum[i]+=matrix [i,j]; 
        }
    }
    
    int max=sum[0];
    int maxI=0;
    for (int i = 0; i < row; i++)
    {
        if (sum [i]>max)
        {
            max=sum [i];
            maxI=i;
        }
    }
    Console.WriteLine("Строка с инднесом "+maxI+" имеет max сумму равную "+max);