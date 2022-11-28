// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] GetArray (int size)
{
    int [] arr= new int [size];
    for (int i = 0; i < size; i++)
    {
        arr [i]=new Random().Next (-100,100);
    }
    return arr;
}

int [] array=GetArray (10);
Console.Write(String.Join(", ", array));
Console.WriteLine();
int sum=0;
for (int i = 1; i < array.Length; i+=2)
{
    sum+=array[i];
}
Console.WriteLine("сумма элементов, стоящих на нечетных позициях,= "+sum);