// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int num=new Random().Next(1,10000);

int GetFiguresSum(int res)
{
    int sum=0;
   while (res>0)
    {
        sum=sum+res%10;
        res/=10;
    }
    return sum;
    }
    Console.Write("сумма цифр числа "+num+" равна "+GetFiguresSum(num));