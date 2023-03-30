/*Задача 10: Напишите программу, 
которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1

Console.Write("Введите трехзначное число ");
int a = int.Parse(Console.ReadLine());
int b = (a % 100) / 10;
if (a<=99 | a>=999) {
Console.WriteLine("Я сказал трехзначное! ");
}
else {
    Console.WriteLine(b);
}



Задача 13: Напишите программу, 
которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Введите число ");
int a = int.Parse(Console.ReadLine());

while  ( a >= 100 )  {
   int b = a/10;
   Console.WriteLine(b);
}
 if (a > 999|a <= 99){
    Console.WriteLine("Третей цифры нет ");
 }
   



/*
Задача 15: Напишите программу, 
которая принимает на вход цифру, 
обозначающую день недели, и проверяет, 
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет

Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());
if (number == 1) 
Console.WriteLine("Понедельник");
if (number == 2) 
Console.WriteLine("Вторник");
if (number == 3) 
Console.WriteLine("Среда");
if (number == 4) 
Console.WriteLine("Четверг");
if (number == 5) 
Console.WriteLine("Пятница");
if (number == 6) 
Console.WriteLine("Суббота");
if (number == 7) 
Console.WriteLine("Воскресенье");
else if (number > 7 | number < 1) { 
    Console.WriteLine("Такого дня нет");
}
*/