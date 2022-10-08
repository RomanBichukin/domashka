//      Двумерные массивы:
//  string[,] table = new string[2,3];........массив строк прямоуг-й
//стринг- тип данных;[,]-указывает на две размерности;[2,3]-де 2 это строки, а 3 это столбцы.....
//  int[,]matrix = new int[5,8]......прямоуг-й массов чисел(матрица в мат-ке)....
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

/* void PrintArray(int[,] matr)// в качестве аргумента пердаем прямог-ю таблицу чисел
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
PrintArray(matrix); */
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
//  f(n) = f(n-1) + f(n-2)

int Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}
for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}