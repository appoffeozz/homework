/*
Задача 21
Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
Console.WriteLine("Введите последовательность координат: ");
Console.Write("Введите ax: ");

double ax = Double.Parse(Console.ReadLine());
Console.Write("Введите ay: ");

double ay = Double.Parse(Console.ReadLine());
Console.Write("Введите az: ");

double az = Double.Parse(Console.ReadLine());
Console.Write("Введите bx: ");

double bx = Double.Parse(Console.ReadLine());
Console.Write("Введите by: ");

double by = Double.Parse(Console.ReadLine());
Console.Write("Введите bz: ");

double bz = Double.Parse(Console.ReadLine());


// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

double distance = GetDistance(ax, bx, ay, by, az, bz);

Console.WriteLine($"расстояние между точками {distance}");

double GetDistance (double ax, double ay, double bx, double by, double az, double bz)
{
    return Math.Sqrt(Math.Pow((bx - ax),2) + Math.Pow((by - ay),2) + Math.Pow((bz - az),2));
}





/*
Задача 23
Напишите программу, которая принимает на вход число
 (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/


/*
Задача 19
Напишите программу, которая принимает на вход пятизначное
 число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/