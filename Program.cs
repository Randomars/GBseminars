void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int InputNum(string tip)
{
    Console.Write(tip);
    return Convert.ToInt32(Console.ReadLine());
}

// Задача 41: Пользователь вводит M чисел. Cколько чисел больше 0 ввёл пользователь.

/*
int[] InputArray(int size)
{
    int[] newArray = new int[size];

    Console.WriteLine($"Создаем массив из {size} чисел.");
    for (int i = 0; i < size; i++)
    {
        newArray[i] = InputNum($"Введите {i + 1} число: ");
    }
    return newArray;
}

void CountPositive(int[] array)
{
    int countPos = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) countPos++;
    }
    Console.WriteLine($"Из {array.Length} чисел {countPos} больше 0.");
}

int m = InputNum("Скольк очисел в массиве (M)?: ");
int[] myArray = InputArray(m);
ShowArray(myArray);
CountPositive(myArray);

*/

// Задача 43: Найти точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем. b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void LineCross(int k1, int b1, int k2, int b2)
{
    double x = b2 - b1;
    double x1 = k1 - k2;
    x = x / x1;
    
    // double x = (b2-b1)/(k1-k2);
    
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения ({x}; {y}).");
}


Console.WriteLine("Задайте параметры двух прямых заданных уравнениями вида (y = k * x + b) для поиска точки пересечения.");
int k1 = InputNum("Значение k1: ");
int b1 = InputNum("Значение b1: ");
int k2 = InputNum("Значение k2: ");
int b2 = InputNum("Значение b2: ");
LineCross(k1, b1, k2, b2);
