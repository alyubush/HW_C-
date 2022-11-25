// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int num1=new Random().Next(1,10);
int num2=new Random().Next(1,7);

int GetNumCube(int res)
{
    int result=1;
for (int i = 1; i <= num2; i++)
{
result=result *num1;
  
}
return result;
}

Console.WriteLine(num1+" в степени "+num2+" равно "+GetNumCube(num1));
