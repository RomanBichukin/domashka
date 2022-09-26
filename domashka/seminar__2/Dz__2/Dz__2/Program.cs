/* Задача 13: Напишите программу, которая выводит третью цифру
 заданного числа или сообщает, что третьей цифры нет.

    645 -> 5
    78 -> третьей цифры нет
    32679 -> 6 */


Console.Clear();
Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

while (A > 999)
{
   A = A / 10;
   if (A < 1000)
   {
      Console.WriteLine($"{A} -> {A%10}");
   }
   
}
if (A < 1000)
{
   Console.WriteLine($"{A} -> {A%10}");
}
 else if (A < 100)
{
   Console.WriteLine($"{A} -> третьей цифры нет");
}