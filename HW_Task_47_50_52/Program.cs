void Main()
{
    bool isWork = true;
    while (isWork)
    {
        Console.WriteLine("Enter command ");
        string command = Console.ReadLine();

        switch (command)
        {
            case "task 47": Task_47();
            break;
            case "task 50": Task_50();
            break;
            case "task 52": Task_52();
            break;
            case "exit": isWork = false;
            break; 
        }
    }
}
Main();

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void Task_47()
{
    InitMassiv();
}
    void InitMassiv()
    {   
        Console.WriteLine("Введите количесво строк: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов: ");
        int b = int.Parse(Console.ReadLine());
        double[,] array = new double [a, b];
        
        PrintMassiv(array);
        
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}  ");
                }
            Console.WriteLine();
        }        
    }

    void PrintMassiv(double[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                double num = new Random().Next(-5, 10) + Math.Round(new Random().NextDouble(), 2);
                array [i,j] = num;
            }
        }
    }

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void Task_50()
{
    Massiv();
}

void Massiv()
    {   
        Console.WriteLine("Введите количесво строк: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов: ");
        int b = int.Parse(Console.ReadLine());
        int [,] array = new int [a, b];

        FillElement(array);
        PrintElement(array);
        InitElemet(array);       
    }

void FillElement(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(1, 20);
            }
        }
}

void PrintElement(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}  ");
                }
            Console.WriteLine();
        }
}

void InitElemet(int [,] array)
{
    Console.WriteLine("Введите число: ");
    int m = int.Parse(Console.ReadLine());        
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {   
                
                if (m == array[i,j])
                {
                    Console.Write($"Число {m} находится в строке{i}, столбце {j}");
                }
                if (m!= array[i,j])
                {
                    Console.Write("Такого числа нет");
                }
                else
                {
                    i++; j++;
                }
                Console.WriteLine();
                
            }
        }

    Console.WriteLine();
}

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Task_52()
{
    MidlSumm();
}

void MidlSumm()
{
    Console.WriteLine("Введите количесво строк: ");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов: ");
    int b = int.Parse(Console.ReadLine());
    int [,] array = new int [a, b];

    FillElement(array);
    PrintElement(array);
    ArithmeticMeanHorizontally(array, a);
    ArithmeticMeanVertically(array);
}

double ArithmeticMeanHorizontally(int [,] array, double midlArifmet)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {    
        int sumHoriz = 0;
        for (int i = 0; i < array.GetLength(0); i++) 
        {
                sumHoriz += array[i,j]; 
                    
        }
        midlArifmet = sumHoriz/array.GetLength(0);
        int q = j + 1;
        Console.Write($"среднее аривметическое в столбце {q} = " + midlArifmet + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
    return midlArifmet;
}

void ArithmeticMeanVertically(int [,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumVertic = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
                sumVertic += array[i,j];
        }
        double midlVertic = sumVertic/array.GetLength(1);
        int q = i + 1;
        Console.Write($"Среднее арифметическое в строке {q} = " + Math.Round(midlVertic, 2) + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
