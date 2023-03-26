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

/* Задача 11 Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

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

