﻿// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double [] array= new double [12];
for (int i = 0; i < array.Length; i++)
    {
        array [i]=new Random().Next(0,500);
    }
Console.Write(String.Join(", ", array));
Console.WriteLine();

double max=array[0];
double min=array [0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i]>max)
    {
        max=array [i];
    }
    if (array[i]<min)
    {
        min=array [i];
    }
}
Console.WriteLine("разница между максимальным и минимальным чмслами = "+(max-min));
