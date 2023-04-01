/*
Random random = new Random();
int randomValue = random.Next(10,100);


int lastDigit = randomValue % 10;
int firstDigit = randomValue / 10;

Console.WriteLine(randomValue);
Console.WriteLine(lastDigit);
Console.WriteLine(firstDigit);


if (lastDigit>lastDigit){
    Console.WriteLine(lastDigit);
}
else {
    Console.WriteLine(firstDigit);
}
*/

/* Задача 11 Напишите программу, 
которая выводит случайное трехзначное число 
и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98

Random random = new Random();
int randomValue = random.Next(100,1000);
int lastDigit = randomValue % 10;
int firsttwoDigit = randomValue / 100 * 10;
int newValue = lastDigit + firsttwoDigit;
Console.WriteLine(randomValue);
Console.WriteLine(newValue);


Console.Write("Введите первое число ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число ");
int number2 = int.Parse(Console.ReadLine());

int res = number1 % number2;

if (res == 0 ){
    Console.Write(res);
    Console.Write("кратно");
}
else {
     Console.Write(res);  прорешать!!!!
     Console.Write("не кратно");
}
адача No14. Общее обсуждение
Напишите программу, которая принимает на вход число 
и проверяет, кратно ли оно одновременно 7 и 23.
● 14 -> нет
● 46 -> нет
● 161 -> да


Console.Write("Введите первое число ");
int num1 = int.Parse(Console.ReadLine());

if ( num1 % 7 == 0 & num1 % 23 == 0){
    Console.WriteLine($" {num1} -> да");
}
else {
    Console.WriteLine($" {num1} -> нет");
}
*/



/*
Задача No16. Работа в группах
Напишите программу, которая принимает на вход
 два числа и проверяет, является ли одно число 
 квадратом другого.
● 5, 25 -> да ● -4, 16 -> да ● 25, 5 -> да ● 8,9 -> нет


Console.Write("Введите первое число ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число ");
int b = int.Parse(Console.ReadLine());

if (b == a*a | a == b*b ) {
    Console.WriteLine ($" {a}, {b} -> да");
}
else {
    Console.WriteLine ($" {a}, {b} -> нет");
}
*/

/*Console.WriteLine("Введите координату");
int x = int.Parse(Console.ReadLine());

int y = int.Parse(Console.ReadLine());

if(x == 0 || y == 0){
    Console.WriteLine("x или y равны нулю, введите верные данные");
return;
}


Console.WriteLine("Введите x");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y");
int y = int.Parse(Console.ReadLine());

int result = GetNumberOfQuarter(x, y);
if (result == 0){
    Console.WriteLine("x или y равны нулю");
    return;
}
Console.WriteLine(result);

int GetNumberOfQuarter(int x, int y)
{
    if(x > 0 && x > 0)
    {
    return 1;
    }
    if(x > 0 && y < 0)
    {
    return 2;
    }
    if(x < 0 && x < 0)
    {
    return 3;
    }
    if(x > 0 && y < 0)
    {
    return 4;
    }
return 0;
}

/*Задача No18. Общее обсуждение
Напишите программу, 
которая по заданному номеру четверти,
показывает диапазон возможных координат точек
в этой четверти (x и y).

Console.WriteLine("Введите Номер четверти");
int x = int.Parse(Console.ReadLine());
string range = GetRangeByQuarter(x);

Console.WriteLine(range);

string GetRangeByQuarter(int x)
{
    if (x == 1)
    {
        return "x > 0 и y > 0  ";
    }
    if (x == 2)
    {
        return "x > 0 и y < 0  ";
    }
    if (x == 3)
    {
        return "x < 0 и y < 0  ";
    }
    if (x == 4)
    {
        return "x > 0 и y < 0  ";
    }
    
        return " ";
    
}



//AB = √(xb - xa)2 + (yb - ya)2

Math.Sqrt
Math.Pow(5, 2)

// Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 2D пространстве.

Console.WriteLine("Введите ax");
double ax = double.Parse(Console.ReadLine());
Console.WriteLine("Введите ay");
double ay = double.Parse(Console.ReadLine());
Console.WriteLine("Введите bx");
double bx = double.Parse(Console.ReadLine());
Console.WriteLine("Введите by");
double by = double.Parse(Console.ReadLine());

double distance = GetDistance(ax, ay, bx, by);

Console.WriteLine($"расстояние между точками {distance}");

double GetDistance (double ax, double ay, double bx, double by)
{
    return Math.Sqrt(Math.Pow((bx - ax),2) + Math.Pow((by - ay),2));
}


Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
от 1 до N.
● 5 -> 1, 4, 9, 16, 25.
● 2 -> 1,4 

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());

SqrTabl(a);

void SqrTabl(int a)
{
    for (int i = 1; i <= a; i++)
    {
        Console.WriteLine(i * i);
    }
}
*/

