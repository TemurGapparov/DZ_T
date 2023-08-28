// Урок 1. Знакомство с языком программирования С#
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7->max = 7
// a = 2 b = 10->max = 10
// a = -9 b = -3->max = -3

// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());

// if (a > b)
// {
//     Console.WriteLine("max = " + a);
// }
// else
// {
//     Console.WriteLine("max = " + b);
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Введите 1-ое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 3-ое число: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Наибольшее число " + Math.Max(num1, Math.Max(num2, num3)));



// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4->да
// - 3->нет
// 7->нет

// Console.Write("Вветиде число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 2 == 0)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Net");
// }
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.Write("Вветиде число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// for (int i = 2; i <= number; i += 2)
// {
//     Console.Write(i + " ");
// }
// Console.Write("Введите число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Четные числа от 1 до {num1}:");
// for (int i = 2; i <= num1; i++)
// {
//     if (i % 2 == 0)
//     {
//         Console.WriteLine(i);
//     }
// }

// !!!!!!!!!!!!
// Console.Write("Вветиде число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// switch (number)
// {
//     case 1:
//         Console.WriteLine("Понедельник");
//         break;

//     case 2:
//         Console.WriteLine("Вторник");
//         break;

//     default:
//         Console.WriteLine("error");
//         break;
// }

// int i = -Convert.ToInt32(Console.ReadLine());
// int e = i;
// Console.WriteLine(i);

// for (; i < e * (-1) + 1; i += 1)
// {
//     Console.Write(i + " ");
// }

// int i = Convert.ToInt32(Console.ReadLine());

// while (i > 9)
// {
//     i -= 10;
// }

// Console.WriteLine(i);

// int Max(int arg1, int arg2, int arg3);
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }
// int[] array = { 543, 5435, 54354, 534, 534, 43, 65, 76, 87 };

// int i = Max(
//     Max(array[0], array[1], array[2]),
//     Max(array[3], array[4], array[5]),
//     Max(array[6], array[7], array[8])
// );
// Console.WriteLine(Max(4, 4, 4));