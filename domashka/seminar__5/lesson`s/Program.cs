﻿Console.Clear();

/* void SayHelloC(string lang)
{
    Console.WriteLine($"Привет {lang}");
}

SayHelloC("C++");
SayHelloC("Python");
string l = "C#";
SayHelloC(l); */


//проверяем какое число больше
/* void SayMax(int x1, int x2)
{
    if(x1 > x2)
    Console.WriteLine($"Max = {x1}");
    else Console.WriteLine($"Max = {x2}");
}

SayMax(3,1);
SayMax(9,15);
SayMax(11,12); */


//ЛИБО ТАК:


/* int SayMax(int x1, int x2)
{
    if(x1 > x2)
    return x1;
    else return x2;
}
Console.WriteLine($"Max = {SayMax(3, 1)}");
SayMax(3,1);
SayMax(9,15);
int l1 = 5;
int l2 = 17;
int max2 = SayMax(l1, l2);
SayMax(11,12);
Console.WriteLine($"Max = {max2}"); */
//========================================================================================
//========================================================================================
//========================================================================================

//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20
//++++++++++



//========================================================================================
//========================================================================================
//========================================================================================
//Задача 32: Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.
//      [-4, -8, 8, 2] -> [4, 8, -8, -2]


//========================================================================================
//========================================================================================
//========================================================================================
//Задача 33: Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
//      4; массив [6, 7, 19, 345, 3] -> нет
//      -3; массив [6, 7, 19, 345, 3] -> да


//========================================================================================
//========================================================================================
//========================================================================================
//Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//      [5, 18, 123, 6, 2] -> 1
//      [1, 2, 3, 6, 2] -> 0
//      [10, 11, 12, 13, 14] -> 5



//========================================================================================
//========================================================================================
//========================================================================================
//Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
//      [1 2 3 4 5] -> 5 8 3
//      [6 7 3 6] -> 36 21