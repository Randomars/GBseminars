
// Задача 47. Двумерный массив размером m×n, заполненный случайными вещественными числами.

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

int InputNum(string tip)
{
    Console.Write(tip);
    return Convert.ToInt32(Console.ReadLine());
}


int m = 3;
int n = 4;
int myMax = 10;
int myMin = -10;

double[,] myArray = CreateRamdom2DArray(m, n, myMin, myMax);
Print2DArray(myArray);


