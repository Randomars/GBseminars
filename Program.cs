/* 
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
*/

/*
// Задача 13. Вывести 3-ю цифру числа, или сообщить что её нет.


string GetThirdNum(int inputNum)
{
    int transNum = inputNum / 100;
    if (transNum > 0) 
    {
        transNum = transNum % 10;
    }
    else
    {
        return "нет (третьей цифры нет)";    
    }
return Convert.ToString(transNum);
}

Console.Write("Введите число:");
int number=Convert.ToInt32(Console.ReadLine());
Console.Write("Третья цифра в числе " + GetThirdNum(number));
*/

// Задача 15. Ввести число. Выходной ли это день?

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

