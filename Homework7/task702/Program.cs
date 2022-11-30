// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("введите кол-во строчек   ");
int rows=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите кол-во столбцов   ");
int columns=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите искомое число   ");
int num =Convert.ToInt32(Console.ReadLine());
int count=0;

int [,] matrix=new int[rows,columns]; 
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j= 0; j < matrix.GetLength(1); j++)
    {
       matrix [i,j]=new Random().Next(0,10); 
       Console.Write(matrix[i,j]+"  "); 
       if (matrix [i,j]==num)
       {
        count++;
       }
    }
    Console.WriteLine ();
}
    
       if (count>0)
       {
        Console.WriteLine ("Искомое число "+num+" есть в массиве");
       }   
    else
    {
        Console.WriteLine ("искомого числа нет в массиве");
    }


