 
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


// Задача 15. Ввести число. Выходной ли это день?
/*
string DayOfAWeek(int inputNum)
{
    if ((inputNum > 0) & (inputNum < 6))
        return "рабочий";
    else
        if ((inputNum == 6) || (inputNum == 7))
            return "выходной";
        else
            return "не существует";
}

Console.Write("Введите число:");
int number=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введенный день недели " + DayOfAWeek(number) + ".");
*/
