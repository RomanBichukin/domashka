//      Напишите программу, которая на вход принимает два числа и выдаёт,
//       какое число большее, а какое меньшее.
//      a = 5; b = 7 -> max = 7
//      a = 2 b = 10 -> max = 10
//      a = -9 b = -3 -> max = -3

Console.Clear();
Console.Write("введите 1-е число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("введите 2-е число: ");
int B = Convert.ToInt32(Console.ReadLine());

if(A > B)
{
    Console.Write($"Результат: {A} > {B}");
}
else
{
    Console.Write($"Результат: {B} > {A}");
}