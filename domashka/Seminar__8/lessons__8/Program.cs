﻿/* Необходимо найти 5 целых чисел (положительных), которые будут удовлетворять такому условию
x^5 + y^5 + z^5 + q^5 = w^5
Т.е. сумма 4 чисел в пятой степени = 5 числу в пятой степени */
Console.Clear();
/* Int64 length = 10;
Int64 start = 1;
for (Int64 x = start; x < length; x++)
{
    for (Int64 y = start; y < length; y++)
    {
        for (Int64 z = start; z < length; z++)
        {
            for (Int64 q = start; q < length; q++)
            {
                for (Int64 w = start; w < length; w++)
                {
                    if (Math.Pow(x, 5) + Math.Pow(y, 5) + Math.Pow(z, 5) + Math.Pow(q, 5) == Math.Pow(w, 5))
                    {
                        System.Console.WriteLine($"{x} + {y} + {z} + {q} = {w}");
                        break;
                    }
                    System.Console.WriteLine($"{x} + {y} + {z} + {q} != {w}");
                }
            }
        }
    }
} */
//============================================================================================================
//============================================================================================================
//============================================================================================================
//Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.
/* int[,] сreatAndShowArray(int raw, int column)
{
    int[,] array = new int[raw, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(3, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}
Console.WriteLine("Исходный массив:");


void showArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] newArr = сreatAndShowArray(5, 5);
Console.WriteLine();

int change = 0;

for (int j = 0; j < newArr.GetLength(1); j++)
{
    change = newArr[0, j];
    newArr[0, j] = newArr[newArr.GetLength(0) - 1, j];
    newArr[newArr.GetLength(0) - 1, j] = change;
}
Console.WriteLine("Полученный массив:");
showArray(newArr); */


//============================================================================================================
//============================================================================================================
//============================================================================================================
//Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

/* int[,] сreatAndShowArray(int raw, int column)
{
    int[,] array = new int[raw, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(3, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}
Console.WriteLine("Исходный массив:");


void showArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] arr55 = сreatAndShowArray(5, 5);
Console.WriteLine();
int change = 0;

for (int i = 0; i < arr55.GetLength(0); i++)
{
    for (int j = i; j < arr55.GetLength(1); j++)
    {
        change = arr55[i, j];
        arr55[i, j] = arr55[j, i];
        arr55[j, i] = change;
        //Console.Write($"{arr55[i, j]} ");
    }
    //break;
    //Console.WriteLine();
}
//Console.WriteLine();
//Console.WriteLine();
Console.WriteLine("Полученный массив:");
showArray(arr55); */


//============================================================================================================
//============================================================================================================
//============================================================================================================
//Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
//Набор данных
/* Частотный массив:
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза
1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза */


//============================================================================================================
//============================================================================================================
//============================================================================================================
//Задача 59: Задайте двумерный массив из целых чисел. 
//Напишите программу, которая удалит строку и столбец, 
//на пересечении которых расположен наименьший элемент массива.
/* Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7 */



//============================================================================================================
//============================================================================================================
//============================================================================================================
//Задача 61: Вывести первые N строк треугольника Паскаля.
// Сделать вывод в виде равнобедренного треугольника

