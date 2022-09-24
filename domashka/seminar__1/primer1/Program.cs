Console.Clear();
Console.Write("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num * num;
Console.WriteLine("Результат: " + result);
            //  можно и так: интерполяция->
            //  Console.Write($"Результат: {result}");
if (num == result)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}