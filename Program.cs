// Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int GetEvenCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) count += 1;
    return count;   
}

int arraySize = 20;
int arrayMinValue = 100;
int arrayMaxValue = 1000;

int[] myArray = CreateRandomArray(arraySize, arrayMinValue, arrayMaxValue);
Console.WriteLine("Ваш массив: ");
ShowArray(myArray);
Console.WriteLine("Количество четных чисел в массиве: " + GetEvenCount(myArray));



// Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.





// Задача 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.




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
/*
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


*/