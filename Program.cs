// Задача 27. Принять число. Выдать сумму цифр числа.

void PrintNumSumm(int num)
{
    int res = 0;
    while (num > 0)
    {
        res = res + num % 10;
        num = num / 10;
    }
    Console.WriteLine($"Сумма цифр числа: {res}");
}


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintNumSumm(number);



// Задача 29. Задать массив из m элементов. Вывести его на экран.




// Задача 19. Является ли 5ти значное число палиндромом?
/*
string GetPalindrom(int inputNum)
{
    int headNum = inputNum % 10;
    int tailNum = inputNum / 10000;
    inputNum = inputNum / 10;
    inputNum = inputNum % 1000;
    if (headNum == tailNum)
    {
        headNum = inputNum % 10;
        tailNum = inputNum / 100;
        if (headNum == tailNum) 
            return "ДА!";
            else return "НЕТ!";
    }
        else return "НЕТ!";
}

Console.Write("Введите 5ти значное число: ");
int number=Convert.ToInt32(Console.ReadLine());
Console.Write("Число палиндром? " + GetPalindrom(number));

*/


// Задача 23. Вывести число. Вывести таблицу кубов.
/*

void ShowKub(int inputNum)
{
    int countNum = 1;
    while (countNum <= inputNum)
    {
        Console.Write(countNum*countNum*countNum + " ");        
        countNum++;
    }

}

Console.Write("Введите число: ");
int number=Convert.ToInt32(Console.ReadLine());
ShowKub(number);
*/