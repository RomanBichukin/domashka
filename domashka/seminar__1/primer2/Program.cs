// на вход два числа, плюс проверка явл. ли первое квадратом второго
//a = 25, b = 5 -> да
//a = 2, b = 10 -> нет

Console.Clear();
Console.Write("введите число 1-е: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("введите число 2-е: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int sqr = num2 * num2;

if (sqr == num1)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}