﻿// Расстояние между точками в 3d
Console.Clear();
Console.WriteLine("Введите координаты 1-й точки: ");
double x1=Convert.ToDouble(Console.ReadLine());
double y1=Convert.ToDouble(Console.ReadLine());
double z1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты 2-й точки: ");
double x2=Convert.ToDouble(Console.ReadLine());
double y2=Convert.ToDouble(Console.ReadLine());
double z2=Convert.ToDouble(Console.ReadLine());
double distance=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
// double pow1=Math.Pow(x2+x1,2);
// double pow2=Math.Pow(y2+y1,2);
// double pow3=Math.Pow(z2+z1,2);
//distance=Math.Round(distance,2);
Console.WriteLine($"Расстояние = {distance}");