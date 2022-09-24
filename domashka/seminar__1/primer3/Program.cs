//  выдавать день недели по заданному номеру
//  3 -> среда
//  5 -> пятница
Console.Clear();
Console.Write("введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
if ( A == 1)
{
    Console.Write("Понеделььник");
}
if ( A == 2)
{
    Console.Write("Вторник");
}
if ( A == 3)
{
    Console.Write("Среда");
}
if ( A == 4)
{
    Console.Write("Четверг");
}
if ( A == 5)
{
    Console.Write("Пятница");
}
if ( A == 6)
{
    Console.Write("Суббота");
}
if ( A == 7)
{
    Console.Write("Воскресенье");
}