// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("введите число b1  ");
double b1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1  ");
double k1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число b2  ");
double b2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2  ");
double k2=Convert.ToInt32(Console.ReadLine());

// k1 * x + b1=k2 * x + b2
// (k1-k2)*x=b2-b1 -> x=(b2-b1)/(k1-k2)
double x=0;
double y=0;
if (k1!=k2)
{
    x=Math.Round((k2-k1)/(b1-b2),3);
    y=Math.Round((k1*x+b1),3);
    Console.WriteLine("Координаты точки пересечения - ("+x+", "+y+")");
}
else if( b1==b2)
{
    Console.WriteLine(" прямые совпадают");
}
else
{
    Console.WriteLine(" прямые параллельные");
}