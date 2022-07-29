int InputNum(string tip)
{
    Console.Write(tip);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateRamdom2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Print2DArray(int[,] takeArray)
{
    for (int i = 0; i < takeArray.GetLength(0); i++)
    {
        for (int j = 0; j < takeArray.GetLength(1); j++)
        {
            Console.Write(takeArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}


// Задача 47. Двумерный массив размером m×n, заполненный случайными вещественными числами.

/*

double[,] CreateRamdom2DArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] newArray = new double[rows, columns];
    const int accuracy = 10;
    double aLeft = 0;
    double aRight = 0;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            aLeft = new Random().Next(minValue, maxValue);
            aRight = new Random().Next(0, accuracy);
            newArray[i, j] =  aLeft + aRight / accuracy;                                
        }
    }
    return newArray;
}

void Print2DArray(double[,] takeArray)
{
    for (int i = 0; i < takeArray.GetLength(0); i++)
    {
        for (int j = 0; j < takeArray.GetLength(1); j++)
        {
            Console.Write(takeArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int m = 3;
int n = 4;
int myMax = 10;
int myMin = -10;

double[,] myArray = CreateRamdom2DArray(m, n, myMin, myMax);
Print2DArray(myArray);

*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

/*

int m = 3;
int n = 4;
int myMax = 9;
int myMin = 1;

Console.WriteLine("Создаю массив.");
int[,] myArray = CreateRamdom2DArray(m, n, myMin, myMax);
Print2DArray(myArray);
Console.WriteLine("Введите позицию элемента.");
m = InputNum("Номер строки: ");
n = InputNum("Номер столбца: ");
if (m > 0 && 
    n > 0 && 
    m <= myArray.GetLength(0) &&
    n <= myArray.GetLength(1))
    Console.WriteLine($"Ваше число {myArray[m - 1, n - 1]}.");
else Console.WriteLine("Такого элемента в массиве нет.");
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void Average(int[,] array)
{
    double summ = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        summ = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            summ = summ + array[j,i];
        }
        Console.Write($"{summ / array.GetLength(0)} ");
    }
}

int m = 3;
int n = 4;
int myMax = 9;
int myMin = 1;

Console.WriteLine("Создаю массив.");
int[,] myArray = CreateRamdom2DArray(m, n, myMin, myMax);
Print2DArray(myArray);
Console.WriteLine("Среднее арифметическое по столбцам:");
Average(myArray);