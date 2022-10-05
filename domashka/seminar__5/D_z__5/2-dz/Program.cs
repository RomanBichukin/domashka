//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//      [3, 7, 23, 12] -> 19
//      [-4, -6, 89, 6] -> 0
Console.Clear();
int[] array = new int[4];
Random rnd = new Random();
int Sum = 0;
for(int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(-100, 100);
    Console.Write($"{array[i]}, ");
    if (i%2 != 0)
    {
        Sum = Sum + array[i];

    }
}
Console.Write($"сумма нечётных позиций -> {Sum}!!!");
