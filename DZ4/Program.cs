// Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. 
// Если число 1 не кратно числу 2, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());

// if (a % b == 0)
// {
//     Console.WriteLine("Kratno");
// }
// else
// {
//     Console.WriteLine($"Ne kratno, ostatok {a % b}");
// }
// Задача №14.
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
// 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

// int a = Convert.ToInt32(Console.ReadLine());

// if (a%7==0 && a%23==0)
// {
//     Console.WriteLine("Da");
// }
// else
// {
//     Console.WriteLine("Net");
// }

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(a%100/10);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int a = Convert.ToInt32(Console.ReadLine());

// if (a / 100 != 0)
// {
//     Console.WriteLine(a % 1000 / 100);
// }
// else
// {
//     Console.WriteLine("третьей цифры нет");
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// int a = Convert.ToInt32(Console.ReadLine());

// if (1 <= a && a <= 5)
// {
//     Console.WriteLine("Da");
// }
// else if (6 <= a && a <= 7)
// {
//     Console.WriteLine("Net");
// }
// else
// {
//     Console.WriteLine("error");
// }

// int[] array = new int[10];
// var str = string.Join(" ", array);
// Console.WriteLine(str);

// void Array(int[] col)
// {
//     int len = col.Length;
//     int index = 0;
//     while (index < len)
//     {
//         col[index] = index + 1;
//         index++;
//     }
// }

// int[] list = new int[7];

// Array(list);

// var str = string.Join(" ", list);
// Console.WriteLine(str);
// int a=Convert.ToInt32(Cpnsole.ReadLine());

using System;

public class MainClass
{
    public static void Main()
    {
        Console.WriteLine("Hello world!")
    }
}