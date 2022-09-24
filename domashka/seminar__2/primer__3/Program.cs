//Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число 2 не кратно числу 1,
// то программа выводит остаток от деления.
//       34, 5 -> не кратно, остаток 4
//       16, 4 -> кратно

Console.Clear();
Console.WriteLine("Введите 1-е число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число: ");
int b = Convert.ToInt32(Console.ReadLine());

int c = a%b;
if(c == 0)
{
    Console.WriteLine("b кратно a");
}
else
{
    Console.WriteLine($"{b} не кратно {a}, остаток {c}");
}