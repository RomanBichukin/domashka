//      Двумерные массивы:
//  string[,] table = new string[2,3];........массив строк прямоуг-й
//стринг- тип данных;[,]-указывает на две размерности;[2,3]-де 2 это строки, а 3 это столбцы.....
//  int[,]matrix = new int[5,8]......прямоуг-й массив чисел(матрица в мат-ке)....
Console.Clear();
/* string[,] table = new string[2, 5];
table[1,2] ="слово"; //обращаемся к 1-й строке 2-го столбца!!!
//table[0,0]    table[0,1]  table[0,2]  table[0,3]  table[0,4]////
//table[1,0]    table[1,1]  table[1,2]  table[1,3]  table[1,4]

for(nint rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)//вложенный цикл,кот-й обозначает столбцы
    {
        Console.WriteLine($"+{table[rows,columns]}+");
    }
} */

/////ТЕПЕРЬ ЦИФРАМИ:
/* int[,] matrix = new int[3, 5];
for(int i = 0; i < matrix.GetLength(0); i++)//GetLength(0)-укажет кол-во строк
{
    for (int j = 0; j < matrix.GetLength(1); j++)//вложенный цикл,кот-й обозначает столбцы
    {                 //GetLength(1) - укажет кол-во столбиков
        Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine();// дл переноса строки на новую и т.д.
} */
//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//ОПИСЫВАЕМ МЕТОД который будет ПЕЧАТАТЬ(первый) И ЗАПОЛНЯТЬ МАТРИЦУ(второй):

void PrintArray(int[,] matr)// в качестве аргумента пердаем прямог-ю таблицу чисел
{
    for (int i = 0; i < matr.GetLength(0); i++)//GetLength(0)-укажет кол-во строк
    {
        for (int j = 0; j < matr.GetLength(1); j++)//вложенный цикл,кот-й обозначает столбцы
        {                 //GetLength(1) - укажет кол-во столбиков
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    for(int j = 0; j < matr.GetLength(1); j++)
    {
        matr[i,j] = new Random().Next(1,10);// [1,10)
    }
    Console.WriteLine();
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);
//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//===================================================================
//      РЕКУРСИЯ:
//факториал.....
/* 
double Factorial (int n)
{
    if(n == 1) return 1;
    else return n * Factorial(n-1);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
} */
//======================================================================
//Числа ФИБОНАЧИ: каждое последующее, равно сумме двух предыдущих...
//  f(1) = 1
//  f(2) = 1
//  f(n) = f(n-1) + f(n-2)_____!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

/* int Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}
for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
} */


//======================================================================================================
//=================СЕМИНАР__6===========================================================================
//======================================================================================================
//**Задача 39:** Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
//      [1 2 3 4 5] -> [5 4 3 2 1]
//      [6 7 3 6] -> [6 3 7 6]
/*     // создаёт рандомный массив!!!!
int[] RandomArrayInt(int elements, int min, int max)
{
    int[] array = new int[elements];
    for(int i = 0; i < elements; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
    //метод возвращает строку из массива int
string ArrayIntToString(int[] arr)
{
    string result = "[";
    for(int i = 0; i < arr.Length; i++)
    if(i < arr.Length - 1)
    {
        result = result + $"{arr[i]}, ";
    }
    else
    {
        result = result + $"{arr[i]}";
    }
    result = result +"]";
    return result;
}
int[] array = RandomArrayInt(10, 100, 1000);
int[] newArray = new int[array.Length];

for (int i = 0; i < array.Length; i++)
{
    newArray[i] = array[array.Length - i -1];
}

Console.Write($"{ArrayIntToString(array)} -> {ArrayIntToString(newArray)}"); */
//=====================================================================================================
//**Задача 40:** Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
//❗ **Теорема о неравенстве треугольника:** каждая сторона треугольника меньше суммы двух других сторон.

/* Console.WriteLine("Введите первую сторону треугольника: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую сторону треугольника: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью сторону треугольника: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a<b+c && b<a+c && c<a+b)
{
    Console.WriteLine("Треугольник с такими параметрами существует!!");
}
else
{
    Console.WriteLine("Такоо треугольника не существует!!");
} */
//=================================================================================================
//**Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//  45 -> 101101
//  3 -> 11
//  2 -> 10

/* Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

string x = string.Empty;
while(a != 0)
{
    x = Convert.ToString(a % 2) + x;///записываем остаток от деления
    a = a /2;
}
Console.WriteLine($"{x}"); */


//=================================================================================================
//**Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
//  Если N = 5 -> 0 1 1 2 3
//  Если N = 3 -> 0 1 1
//  Если N = 7 -> 0 1 1 2 3 5 8
  //метод возвращает строку из массива int
/* string ArrayIntToString(int[] arr)
{
    string result = "[";
    for(int i = 0; i < arr.Length; i++)
    if(i < arr.Length - 1)
    {
        result = result + $"{arr[i]}, ";
    }
    else
    {
        result = result + $"{arr[i]}";
    }
    result = result + "]";
    return result;
}
Console.WriteLine($"Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] f = new int[a];
f[0] = 0;
f[1] = 1;
for(int i = 2; i < a; i++)
{
    f[i] = f[i - 1] + f[i-2];
}
Console.WriteLine($"{a} -> {ArrayIntToString(f)}"); */

/* Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
 */

//=================================================================================================
//Задача 45: Напишите программу, которая будет создавать копию заданного массива
// с помощью поэлементного копирования.