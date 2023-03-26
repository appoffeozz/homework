/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Console.Write("Введите первое число ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int b = int.Parse(Console.ReadLine());
if (a < b) {
    Console.WriteLine("Первое число меньшее, а второе большее ");
}
else {
    Console.WriteLine("Первое число большее, а второе меньшее ");
}

/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

Console.Write("Введите первое число ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите третее число ");
int c = int.Parse(Console.ReadLine());
int max = a;
if (b > a)
    max = b;
if (c > b) 
    max = c;
Console.WriteLine(max);

/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет


Console.Write("Введите первое число ");
int a = int.Parse(Console.ReadLine());
if ( a%2 == 0 ){
    Console.Write(" Четное ");
}
else {
    Console.Write(" не четное ");
}

Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8


Console.Write("Введите число ");
int N = int.Parse(Console.ReadLine());
for (int i = 1; i <= N; i++)
    if (i % 2 == 0)
       Console.Write($"{i} ");
       */