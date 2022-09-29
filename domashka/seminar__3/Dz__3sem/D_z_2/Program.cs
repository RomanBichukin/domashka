//Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве^
//      A (3,6,8); B (2,1,-7), -> 15.84
//      A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Введите координаты первой точки: ");
int[] X = new int[3] { Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), };
Console.WriteLine("Введите координаты первой точки: ");
int[] Y = new int[3] { Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), };

Console.WriteLine(Math.Sqrt((Math.Pow((Y[0] - X[0]), 2)) + (Math.Pow((Y[1] - X[1]), 2)) + (Math.Pow((Y[2] - X[2]), 2))));