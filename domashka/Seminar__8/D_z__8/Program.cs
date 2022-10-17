/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
 по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */
Console.Clear();

/* void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    Console.WriteLine("Исходный массив:");

}

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] table = new int[4, 4];
FillArrayRandom(table);
PrintArray(table);
SortArray(table);
Console.WriteLine("Результат сортировки:");
PrintArray(table); */

//------------------------------------------------------------------------------------------------
//------------------------------------------------------------------------------------------------
/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
 которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке
 и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

/* int[,] CreateMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],1} ");
            else Console.Write($"{matrix[i, j],1}");
        }
        Console.WriteLine();
    }
}

void SumStringMatrix(int[,] matrix)
{
    int index = 0, minsum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} строки = {sum}");
        if (i == 0)
        {
            minsum = sum;
        }
        else if (sum < minsum)
        {
            minsum = sum;
            index = i;
        }
    }
    string line = string.Empty;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        line += matrix[index, j] + " ";
    }
    Console.Write($"Строка с минимальной суммой элементов равна {index+1}. ");
}


int[,] array = CreateMatrix(4, 4, 0, 9);//поменяем  цифры получим прямоугольный массив
PrintMatrix(array);
SumStringMatrix(array); */

//--------------------------------------------------------------------------------------------------
//--------------------------------------------------------------------------------------------------
/* Задача 58: Задайте две матрицы. Напишите программу,
 которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

/* Random rnd = new Random();
int[,] CreateMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],1}|");
            else 
            {
                Console.Write($"{matrix[i, j]}");
            }
        }
        Console.WriteLine();
    }
}
//ВАЖНО не забудь: строка умноженая настобец!!!!!!!!!!!!!!!

int[,] DivMatrix(int[,] matrix1, int[,] matrix2)
{
    var matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
                for (int n = 0; n < matrix1.GetLength(1); n++)
                {
                    matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
                }
            }
        }
    }
    return matrix3;
}

int[,] array = CreateMatrix(2, 2, 0, 9);    //можно и так (rnd.Next(?,?), rnd.Next(?, ?), 0, 9)
int[,] matrix = CreateMatrix(2, 2, 0, 9);   // задать случайный размер матриц

Console.WriteLine("Первая матрица:");
PrintMatrix(array);
Console.WriteLine("Вторая матрица:");
PrintMatrix(matrix);
Console.WriteLine("Результаи умножения:");
PrintMatrix(DivMatrix(array, matrix)); */

//---------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------
/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
 Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

/* int[,,] array = new int[2, 2, 2];
FillArray(array);
PrintIndex(array);

void PrintIndex(int[,,] arr)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

void FillArray(int[,,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] += count;
                count = count + 3;
            }
        }
    }
} */

//---------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------
/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */
/* void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] array = new int[4, 4];

int n = 1;
int a = 0;
int b = 0;

while (n <= array.GetLength(0) * array.GetLength(1))
{
    array[a, b] = n;
    n++;
    if (a <= b + 1 && a + b < array.GetLength(1) - 1)
    {
        b++;
    }
    else if (a < b && a + b >= array.GetLength(0) - 1)
    {
        a++;
    }
    else if (a >= b && a + b > array.GetLength(1) - 1)
    {
        b--;
    }
    else
    {
        a--;
    }
}
PrintArray(array); */