//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//      452 -> 11
//      82 -> 10
//      9012 -> 12
Console.Clear();
Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int result = 0;
while (A > 0)
{
    result = result + A%10;
    A = A / 10;
    
}
Console.WriteLine(result);