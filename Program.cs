 
// Задача 10. Вывести вторую цифру введенного числа.

int GetSecondNum(int inputNum)
{
    int transNum = inputNum / 10;
    transNum = transNum % 10;
    return transNum;
}

Console.Write("Введите 3х значное число: ");
int number=Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая цифра " + GetSecondNum(number));




/*
// Задача 2. Вывести квадрат числа

Console.Write("Введите число:");
int num=Convert.ToInt32(Console.ReadLine());
Console.Write("Квадрат числа равен " + num*num);
*/

// Задача 3. Наименьшее и наибольшее из 2х чисел
/*
int min, max;

Console.Write("Введите 1е число:");
int num1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2е число:");
int num2=Convert.ToInt32(Console.ReadLine());

if (num1>num2) 
{
    max=num1;
    min=num2;
}
else
{
    if (num2>num1) 
    {
        max=num2;
        min=num1;
    }
    else
    {
        Console.WriteLine("Числа равны");
        max=num1;
        min=num2;
    }
}

Console.WriteLine("Большее число " + max);
Console.WriteLine("Меньшее число " + min);
*/

// Задача 4. Наибольшее из 3х чисел
/*
int max;

Console.Write("Введите 1е число:");
int num1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2е число:");
int num2=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3е число:");
int num3=Convert.ToInt32(Console.ReadLine());

if (num1>num2)
    max=num1;
else
    max=num2;
if (num3>max)
    max=num3;

Console.WriteLine("Большее число " + max);
*/

// Задача 6. Определение четности числа
/*
double numClon;

Console.Write("Введите число:");
int num=Convert.ToInt32(Console.ReadLine());
numClon=num;

if (num/2==numClon/2) 
    Console.WriteLine("Четное число");
else
    Console.WriteLine("Нечетное число");

// Задача 8. Вывести ряд четных чисел до N

int counter=2;
Console.Write("Введите число:");
int num=Convert.ToInt32(Console.ReadLine());

while (counter<=num)
{
    Console.Write(counter + " ");
    counter=counter+2;
}
*/

