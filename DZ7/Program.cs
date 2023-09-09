// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

// void Triangle(int a, int b, int c)
// {
//     if (a < b + c && b < a + c && c < a + b) Console.WriteLine($"Треуголбник со сторонами {a}, {b}, {c} существует");
//     else Console.WriteLine($"Треуголбник со сторонами {a}, {b}, {c} не существует");
// }

// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// int c = Convert.ToInt32(Console.ReadLine());

// Triangle(a, b, c);

// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

// int[] array = { 1, 3, 5, 67 };

// int[] copy = new int[array.Length];
// Array.Copy(array, copy, array.Length);

// Console.WriteLine(String.Join(" ", copy));

//  Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// void Fibonachi(int[] array)
// {
//     int prev = 0;
//     int next = 1;
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = prev;
//         prev = next;
//         next = array[i] + next;
//     }
// }

// int number = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[number];
// Fibonachi(array);

// Console.WriteLine($"Если N = {number} -> {String.Join(" ", array)}");

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10f

// string Binary(int number)
// {
//     string result = string.Empty;
//     while (number != 0)
//     {
//         result += (number % 2).ToString();
//         number = number / 2;
//     }
//     char[] sReverse = result.ToCharArray();
//     Array.Reverse(sReverse);
//     return new string(sReverse);
// }

// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{number} -> {Binary(number)}");

// string Binary(int number)
// {
//     string result = string.Empty;
//     while (number != 0)
//     {
//         result = (number % 2) + result;
//         number = number / 2;
//     }
//     return result;
// }

// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{number} -> {Binary(number)}");

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int Count(string[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (Int32.Parse(array[i]) > 0) count++;
//     }
//     return count;
// }

// string number = "1, -7, 567, 89, 223";

// string[] array = number.Split(", ");

// Console.WriteLine($"{String.Join(" ", array)} -> {Count(array)}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// double[] Coordinate(double b1, double k1, double b2, double k2)
// {
//     double[] coord = new double[2];
//     coord[0] = (b2 - b1) / (k1 - k2);
//     coord[1] = k2 * coord[0] + b2;
//     return coord;
// }

// double b1 = 2; double k1 = 5; double b2 = 4; double k2 = 9;

// Console.WriteLine($"b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> ({String.Join("; ", Coordinate(b1, k1, b2, k2))})");


