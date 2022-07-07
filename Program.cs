// Задача 27. Принять число. Выдать сумму цифр числа.
/*
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

*/

// Задача 29. Задать массив из m элементов. Вывести его на экран.

void FillArray(int[] someArray)
{
    int length = someArray.Length;
    for (int i = 0; i < length; i++)
        someArray[i] = new Random().Next(1,100);
}

void PrintArray(int[] someArray)
{
    int length = someArray.Length;
    Console.WriteLine("Ваш массив:");
    for (int i = 0; i < length; i++)
    {
        Console.Write(someArray[i] + ", ");
    }
}

Console.Write("Введите размерность массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int [number];
FillArray(myArray);
PrintArray(myArray);


