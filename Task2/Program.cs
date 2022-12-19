// Задача № 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите координаты двух точек: ");
double Xa = double.Parse(Console.ReadLine()!);
double Ya = double.Parse(Console.ReadLine()!);
double Za = double.Parse(Console.ReadLine()!);
double Xb = double.Parse(Console.ReadLine()!);
double Yb = double.Parse(Console.ReadLine()!);
double Zb = double.Parse(Console.ReadLine()!);
double AB = Math.Sqrt(Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2)+ Math.Pow(Zb - Za, 2));
Console.WriteLine("Расстояние между двумя точками в 3D пространстве = " + AB);