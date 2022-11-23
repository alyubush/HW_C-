// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int num=new Random().Next(-10000,100000);
Console.WriteLine(num);
int result=0;

if (num>99)
{    
while(result==0)
{
    if (num>99&&num<1000)
    {
     result=num%10;  
    }
        num/=10;
}
Console.WriteLine(result);
}
else if (num<-99)
{   
while(result==0)
{
    if (num<-99&&num>-1000)
    {
     result=num%10;  
    }
        num/=10;
}
Console.WriteLine(result);
}
else
{
    Console.WriteLine("третьей цифры нет");
}




