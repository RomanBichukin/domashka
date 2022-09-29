//  Напишите программу, которая на вход принимает число (N),
//   а на выходе показывает все чётные числа от 1 до N.
//      5 -> 2, 4
//      8 -> 2, 4, 6, 8

Console.Clear();
Console.Write("Введите число:  ");
int A = Convert.ToInt32(Console.ReadLine());

int B = 2;
    while(A > B)
    {
        Console.Write($"{B},");
        B = B + 2;
    }
/*  или можно так:
int B = 1;
while ( B <= A )
{
    if (B%2 == 0) Console.Write($"{B} ");
    B += 2
} */