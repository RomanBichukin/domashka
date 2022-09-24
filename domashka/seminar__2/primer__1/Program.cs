//Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.
//      78 -> 8
//      12-> 2
//      85 -> 8
Console.Clear();
int x = new Random().Next(10, 100);
Console.WriteLine(x);
int second = x%10;
int first = (x - second)/10;
if (first > second)
{
    Console.WriteLine(first);
}
else
{
    Console.WriteLine(second);
}