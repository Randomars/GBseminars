// Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
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
        if (array[i] % 2 == 0) count++;
    return count;   
}

int arraySize = 20;
int arrayMinValue = 100;
int arrayMaxValue = 1000;

int[] myArray = CreateRandomArray(arraySize, arrayMinValue, arrayMaxValue);
Console.WriteLine("Ваш массив: ");
ShowArray(myArray);
Console.WriteLine("Количество четных чисел в массиве: " + GetEvenCount(myArray));

*/

// Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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

int GetOddIndexSumm(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
        if (i % 2 > 0) summ += array[i];
    return summ;
}

int arraySize = 10;
int arrayMinValue = -99;
int arrayMaxValue = 100;

int[] myArray = CreateRandomArray(arraySize, arrayMinValue, arrayMaxValue);
Console.WriteLine("Ваш массив: ");
ShowArray(myArray);
Console.WriteLine("Сумма нечетных позиций: " + GetOddIndexSumm(myArray));





// Задача 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.



