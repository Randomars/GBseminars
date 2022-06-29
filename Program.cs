/* 
// Задача 1. Вывести день недели.

Console.Write("Чтобы узнать день недели, введите число:");
int day=Convert.ToInt32(Console.ReadLine());

if (day==1) Console.WriteLine("Понедельник");
if (day==2) Console.WriteLine("Вторник");
if (day==3) Console.WriteLine("Среда");
if (day==4) Console.WriteLine("Четверг");
if (day==5) Console.WriteLine("Пятница");
if (day==6) Console.WriteLine("Суббота");
if (day==7) Console.WriteLine("Воскресенье");
if ((day>7) || (day<1)) Console.WriteLine("Такого дня в неделе нет");
*/

// Задача 2. Вывести квадрат числа

Console.Write("Введите число:");
int num=Convert.ToInt32(Console.ReadLine());
Console.Write("Квадрат числа равен " + num*num);

