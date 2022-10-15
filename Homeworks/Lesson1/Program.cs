/* Домашнее задание №2. Вариант 1.
// Задание №2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("input a first number a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input a second number b: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a > b)
{
    Console.WriteLine("firs number a > second number b");
}
    else if(a < b)
{
    Console.WriteLine("firs number a < second number b");
}
*/

/*Домашнее задание №2. Вариант 2.
// Задание №2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("input a first number a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("input a second number b: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
int min = a;
if(a > max) max = a;
if(a < max) min = a;
if(b > max) max = b;
if(b < min) min = b;
Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);
*/

/* Домашнее задание №4.
// Задание №4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("input a first number a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("input a second number b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("input a third number c: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;
Console.Write("max = ");
Console.WriteLine(max);
*/

/* Домашнее задание №6.
//Задание №6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("input number a: ");
int a = Convert.ToInt32(Console.ReadLine());
if(a % 2 == 0)
{
    Console.WriteLine("an even number");
}
else
{
    Console.WriteLine("an odd number");
}
*/

/*Домашнее задание №8.
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("input a number: ");
int N = Convert.ToInt32(Console.ReadLine());
int current = 1;
while(current <= N)
{
    Console.Write(current+1);
    current+=2;
} 
*/ 