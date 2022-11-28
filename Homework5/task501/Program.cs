// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



int [] GetArray (int size)
{
    int [] arr=new int [size];
    for (int i = 0; i < size; i++)
    {
       arr [i]= new Random().Next (100,1000); 
    }
    return arr;
}

int []array=GetArray(10);
Console.Write(String.Join(", ", array));
Console.WriteLine();
int count=0;
for (int i = 0; i <array.Length; i++)
{
    if (array[i]%2==0)
    {
        count++;
    }

}
Console.WriteLine("в массиве "+count+" четных чисел");