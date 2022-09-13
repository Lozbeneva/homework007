//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] Fill2DArrray(int row, int column, int minValue, int maxValue)
{
    double[,] array2D = new double[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            double a = new Random().Next(minValue, maxValue + 1); //генерация целой части
            double b = new Random().NextSingle(); //генерация дробной части
            array2D[i, j] = Math.Round(a + b, 1); //метод Math.Round сокращает число знаков после запятой
        }
    }
    return array2D;
}

void Print2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           
            Console.Write(array[i, j] + "; ");

        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк -> ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов -> ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

double[,] massive = Fill2DArrray(m, n, -10, 10);
Print2DArray(massive);




//****************************************************************************
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//на семинаре решили искать элемент и выводить его позицию в массиве

int[,] Fill2DArrrayInt(int row, int column, int minValue, int maxValue)
{
    int[,] array2D = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array2D[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array2D;
}

void Print2DArrayInt(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            Console.Write(array[i, j] + "; ");

        }
        Console.WriteLine();
    }
}


Console.WriteLine("Введите количество строк -> ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов -> ");
int n = int.Parse(Console.ReadLine());

int[,] massiveInt = Fill2DArrrayInt(m, n, 0, 10);
Print2DArrayInt(massiveInt);

Console.WriteLine("Введите искомый элемент -> ");
int el = int.Parse(Console.ReadLine());

for (int i = 0; i < massiveInt.GetLength(0); i++)
{
    for (int j = 0; j < massiveInt.GetLength(1); j++)
    {
        if (massiveInt[i, j] == el)
        {
            Console.WriteLine($"Элемент {el} найден на позиции [{i},{j}]");
            return;
        }
    }
}
Console.WriteLine($"Элемент {el} не найден в массиве");



//****************************************************************************
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце


Console.WriteLine("Введите количество строк -> ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов -> ");
int columns = int.Parse(Console.ReadLine());

int[,] massiveInt = Fill2DArrrayInt(rows, columns, 0, 10);
Print2DArrayInt(massiveInt);

double[] arithmeticMean = new double[columns];


for (int i = 0; i < columns; i++)
{
    for (int j = 0; j < rows; j++)
    {
        arithmeticMean[i] += massiveInt[j, i];
    }
    arithmeticMean[i] = Math.Round(arithmeticMean[i]/rows, 1);
}

Console.WriteLine("Среднее арифметическое каждого столбца: ");
Console.WriteLine(String.Join(", ", arithmeticMean));