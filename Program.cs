// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Введите пятизначное число: ");
//         int number = Convert.ToInt32(Console.ReadLine());

//         bool isPalindrome = IsPalindrome(number);

//         if (isPalindrome)
//         {
//             Console.WriteLine("Да, число является палиндромом");
//         }
//         else
//         {
//             Console.WriteLine("Нет, число не является палиндромом");
//         }
//     }

//     static bool IsPalindrome(int number)
//     {
//         string numberString = number.ToString();
//         int length = numberString.Length;

//         for (int i = 0; i < length / 2; i++)
//         {
//             if (numberString[i] != numberString[length - 1 - i])
//             {
//                 return false;
//             }
//         }

//         return true;
//     }
// }



// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Введите координаты точки A:");
//         Console.Write("X: ");
//         double ax = Convert.ToDouble(Console.ReadLine());
//         Console.Write("Y: ");
//         double ay = Convert.ToDouble(Console.ReadLine());
//         Console.Write("Z: ");
//         double az = Convert.ToDouble(Console.ReadLine());

//         Console.WriteLine("\nВведите координаты точки B:");
//         Console.Write("X: ");
//         double bx = Convert.ToDouble(Console.ReadLine());
//         Console.Write("Y: ");
//         double by = Convert.ToDouble(Console.ReadLine());
//         Console.Write("Z: ");
//         double bz = Convert.ToDouble(Console.ReadLine());

//         double distance = CalculateDistance(ax, ay, az, bx, by, bz);
//         Console.WriteLine("\nРасстояние между точками A и B: " + distance.ToString("F2"));
//     }

//     static double CalculateDistance(double ax, double ay, double az, double bx, double by, double bz)
//     {
//         double dx = bx - ax;
//         double dy = by - ay;
//         double dz = bz - az;

//         double distance = Math.Sqrt(dx * dx + dy * dy + dz * dz);
//         return distance;
//     }
// }



// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Введите число N: ");
//         int n = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("Таблица кубов чисел от 1 до " + n + ":");

//         for (int i = 1; i <= n; i++)
//         {
//             int cube = i * i * i;
//             Console.Write(cube + " ");
//         }
//     }
// }





