//Задайте двумерный массив размером m1×n, заполненный случайными 
//вещественными числами.

double[,] CreateArray(int m1, int n1)
{
    
    double[,] array = new double[m1, n1];
    for(int i = 0; i < m1; i++)
    {
        for(int j = 0; j < n1; j++)
        array[i, j] = new Random().Next(1, 10) + new Random().NextDouble();
    }
    return array;
}
void ShowArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i ++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.Write("Input number of strings: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine();
double[,] array1 = CreateArray(m1, n1);
ShowArray(array1);
Console.WriteLine();

//Напишите программу, которая на вход принимает позиции элемента в
//двумерном массиве, и возвращает значение этого элемента или же указание,
//что такого элемента нет.

int[,] CreateArray2(int m, int n)
{
    int[,] array = new int[m, n];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
           array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}
void ShowArray2(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
          Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void ShowValue(int[,] array, int row, int column)
{
    if(row > array.GetLength(0) | column > array.GetLength(1))
    {
        Console.WriteLine("Out of range!");
    }
    else Console.WriteLine($"The value of an element is: {array[row - 1, column - 1]}");
}
Console.Write("Input number of strings: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array2 = CreateArray2(m2, n2);
ShowArray2(array2);
Console.Write("Input the string value of an element that you want to see: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the column value of an element that you want to see: ");
int column = Convert.ToInt32(Console.ReadLine());
ShowValue(array2, row, column);
Console.WriteLine();

//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
//элементов в каждом столбце.

int[,] CreateArray3(int m3, int n3)
{
    int[,] array = new int[m3, n3];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}
void ShowArray3(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
          Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void ArithmeticMean(int[,] array)
{
    double arithMean= 0;
    for(int j = 0; j < array.GetLength(1); j++)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            arithMean += array[i, j];
        }
        arithMean = arithMean / array.GetLength(0);
        Console.Write(arithMean + "  ");
        arithMean= 0;
    }
}
Console.Write("Input number of strings: ");
int m3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array3 = CreateArray3(m3, n3);
ShowArray3(array3);
ArithmeticMean(array3);