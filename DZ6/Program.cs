// int Parse(string text)
// {
//     Console.WriteLine(text);
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }

// int Sum(int number)
// {
//     int sum = 0;
//     for (int i = 1; i <= number; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }


// int number = Parse("Введите число");
// int sum = Sum(number);

// Console.WriteLine(sum);

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.WriteLine(Convert.ToInt32(Console.ReadLine()).ToString().Length);

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// int Parse(int number)
// {
//     int sum = 1;
//     for (int i = 1; i <= number; i++)
//     {
//         sum *= i;
//     }
//     return sum;
// }

// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Parse(number));

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// void Random(int[] array)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(2);
//     }
// }

// // // void PrintArr(int[] array)
// // // {
// // //     for (int i = 0; i < array.Length; i++)
// // //     {
// // //         Console.Write(array[i]+" ");
// // //     }
// // // }

// int[] array = new int[8];

// Random(array);
// // // PrintArr(array);
// // // foreach (int i in array)
// // // {
// // //     Console.Write(i + " ");
// // // }
// Console.WriteLine(String.Join(" ", array));

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Pow(int x, int y)
// {
//     int q = x;
//     for (int i = 1; i < y; i++)
//     {
//         q *= x;
//     }
//     return q;
// }

// Console.WriteLine(Pow(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int Sum(int number)
// {
//     int sum = 0;
//     string num = number.ToString();
//     for (int i = 0; i < num.Length; i++)
//     {
//         // Console.WriteLine(num[i]);
//         if (num[i] != '-')
//             {
//             // Console.WriteLine(num[i]);
//             // Console.WriteLine(Convert.ToInt32(num[i]));

//             sum += Convert.ToInt32(num[i].ToString());

//         }
//         // Console.WriteLine(sum);    
//     }
//     return sum;
// }

// Console.WriteLine(Sum(82));

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// void Random(int[] array)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(100);
//     }
// }

// void Array(int[] array)
// {
//     Random rand = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rand.Next(0, 100);
//     }
// }

// int[] array = new int[Convert.ToInt32(Console.ReadLine())];
// Array(array);
// Console.Write("[");
// Console.Write(String.Join(", ", array));
// Console.Write("]");

// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// void Random(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-9, 10);
//     }
// }

// int[] array = new int[Convert.ToInt32(Console.ReadLine())];

// Random(array);

// Console.WriteLine(string.Join(", ", array));
// foreach (int i in array)
// {
//     if (array[array.Length - 1] == i) Console.Write(-i + " ");
//     else Console.Write(-i + ", ");
// }
// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да

// void Random(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-9, 10);
//     }
// }

// string Array(int[] array, int x)
// {
//     string str = String.Empty;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == x)
//         {
//             str = "Да";
//             break;
//         }
//         else
//         {
//             str = "Нет";
//         }

//     }
//     return str;
// }

// int[] array = new int[Convert.ToInt32(Console.ReadLine())];
// int x = Convert.ToInt32(Console.ReadLine());

// Random(array);

// Console.WriteLine($"{x}; массив [{String.Join(", ", array)}] -> {Array(array, x)}");