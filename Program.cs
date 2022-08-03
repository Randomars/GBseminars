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


// Задача 54: Упорядочить по убыванию элементы каждой строки двумерного массива.

/*

int[,] SortStringsDesc(int[,] takeArray)
{
    bool changed = true;
    int temp = 0;
   
    for (int i = 0; i < takeArray.GetLength(0); i++)
    {
        changed = true;
        
        while (changed)
        {
            changed = false;
            for (int j = 1; j < takeArray.GetLength(1); j++)
            {
                if (takeArray[i,j-1] < takeArray[i,j])
                {
                    temp = takeArray[i,j-1];
                    takeArray[i,j-1] = takeArray[i,j];
                    takeArray[i,j] = temp;
                    changed = true;
                }
            }
        }
       
    }
    return takeArray;
}

int m = 3;
int n = 4;
int myMax = 9;
int myMin = 1;

Console.WriteLine("Создаю массив.");
int[,] myArray = CreateRamdom2DArray(m, n, myMin, myMax);
Print2DArray(myArray);
Console.WriteLine("Упорядычиваю элементы в строках по убыванию:");
myArray = SortStringsDesc(myArray);
Print2DArray(myArray);
*/


// Задача 56: В массиве найти строку с наименьшей суммой элементов.

/*

int[,] SummInStrings(int[,] takeArray)
{
    int[,] stSumm = new int[takeArray.GetLength(0), 1];

    for (int i = 0; i < takeArray.GetLength(0); i++)
    {
        stSumm[i, 0] = 0; 
        for (int j = 0; j < takeArray.GetLength(1); j++)
        {
            stSumm[i, 0] = stSumm[i, 0] + takeArray[i,j];
        }
    }
    return stSumm;
}

int FindMin(int[,] takeArray)
{
    int minNumIndex = 0;
    for (int i = 1; i < takeArray.GetLength(0); i++)
    {
        if (takeArray[i, 0] < takeArray[minNumIndex, 0])
            minNumIndex = i;
    }
    return minNumIndex;
}


int m = 5;
int n = 4;
int myMax = 9;
int myMin = 1;

Console.WriteLine("Создаю массив.");
int[,] myArray = CreateRamdom2DArray(m, n, myMin, myMax);
Print2DArray(myArray);
Console.WriteLine("Поиск строки с наименьшей суммой элементов.");
int[,] summArray = new int[myArray.GetLength(0), 1];  // Массив сумм строк. Для совместимости с функцией вывода задан в формате 2d.
summArray = SummInStrings(myArray);
Print2DArray(summArray);
Console.WriteLine($"Наименьшая сумма элементов в {FindMin(summArray) + 1} строке.");

*/

// Задача 62. Заполните спирально массив 4 на 4.
/*
int[,] CreateSpiralArray(int rows, int columns)
{
    int maxNum = rows * columns;
    int counter = 1;
    int[,] newArray = new int[rows, columns];
    int i = 0;
    int j = 0;
    int di = 0;
    int dj = 1;
    

    while (counter <= maxNum)
        {
            newArray[i, j] = counter;
                 
            if (j + dj > columns - 1 || 
                j + dj < 0 || 
                i + di > rows - 1 || 
                i + di < 0 ||
                newArray[i + di, j + dj] != 0)
                {
                    if (di == 0)
                    {
                        di = dj;
                        dj = 0;
                    }
                    else
                    {
                        dj = - di;
                        di = 0;
                    }
                }
            counter++;
            j = j + dj;
            i = i + di;
        }
    return newArray;    
}


int m = 6;
int n = 6;

Console.WriteLine("Создаю массив.");
int[,] myArray = CreateSpiralArray(m, n);
Print2DArray(myArray);
*/

// Задача 64: Найти кол-во цифр в числе N рекурсивным методом

int CountDigit(int n)
{
    if(n / 10 >= 1 )
        return 1 + CountDigit(n / 10);
    else
        return 1;
}

int myNum = InputNum("Введите число: ");
Console.WriteLine($"В вашем числе {CountDigit(myNum)} цифр.");


