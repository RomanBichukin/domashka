//  Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.
//  4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//  2 -> " -2, -1, 0, 1, 2"

Console.Clear();
Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

int B;

if(A >= 0)
{
    B = A * (-1);
         while (B <= A)
         {
            
             Console.WriteLine(B);
             B = B + 1;
          }   
}
else
{
    B = A * (-1);
    while(A <= B)
    {
        Console.WriteLine(B);
        A = A + 1;
    }
}
