//Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
//      [3 7 22 2 78] -> 76


Console.Clear();

double[] array = new double[10];
Random rnd = new Random();
//int max = array[i];
//int min = array[i];
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.NextDouble() * 100;
    Console.WriteLine("{0,3:F2}", array[i]);//"{0,3}:F2" - ограничиваем кол-вр знаков после запятой!!!
}

/* for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(100);
    Console.Write("{0,3:F2}",array[i] + "  ");
} */

/* void PrintArray(double[] array)
{
   for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble() * 100;
        Console.Write("{0,3:F2}",array[i] + " ");
    }
    //Console.WriteLine();
}
PrintArray(array);
 */


double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}

Console.WriteLine($"всего {array.Length} чисел. ");
Console.WriteLine($"Максимальное значение = {max} ");
Console.WriteLine($"минимальное значение = {min} ");
Console.WriteLine($"Разница между max и min значением = {max - min}");