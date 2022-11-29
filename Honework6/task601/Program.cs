// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.WriteLine ("Введите число M   ");
int n=Convert.ToInt32(Console.ReadLine());


    int [] array=new int [n];
    int count=0;
    for (int i = 0; i < n; i++)
    {
        array [i]=new Random().Next(-200,1000);
        if (array[i]>0)
        {
           count++;
        }
    }
   
   Console.Write(String.Join(", ", array));
   Console.WriteLine();
   Console.WriteLine("в массиве "+count+" положительных чисел");
   