// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int row= 4;
int column=4;
int a=1;
int [,]martix =new int [row,column];

for (int j = 0; j < column; j++)
{
    martix[0,j]=a;
    a++;
}
for (int i = 1; i < row; i++)
{
    martix[i,column-1]=a;
    a++;
}
for (int j=column-2; j >=0; j--)
{
    martix[row-1,j]=a;
    a++;
}
for (int i=row-1; i >1; i--)
{
    martix[i-1,0]=a;
    a++;
}
for (int j = 0+1; j < column-1; j++)
{
    martix[1,j]=a;
    a++;
}
for (int i = 1+1; i < row-1; i++)
{
    martix[i,column-1-1]=a;
    a++;
}
for (int j=column-2-1; j >=1; j--)
{
    martix[row-1-1,j]=a;
    a++;
}
    
    
     for (int i = 0; i <martix.GetLength(0); i++)
    {
        for (int j = 0; j <martix.GetLength(1); j++)
        {
            Console.Write(martix [i,j]+",  ");
        }
        Console.WriteLine();
    }
