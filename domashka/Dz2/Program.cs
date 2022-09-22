//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//      2, 3, 7 -> 7
//      44 5 78 -> 78
//      22 3 9 -> 22
Console.Clear();

Console.Write("Введите 1-е число:  ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число:  ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-е число:  ");
int C = Convert.ToInt32(Console.ReadLine());


if(A > C)
{
    if(A > B)
    {
        Console.Write($"Max = {A} ");
    }
    else
    {
        Console.Write($"Max = {B} ");
    }
}
else
{
        Console.Write($"Max = {C} ");
}
