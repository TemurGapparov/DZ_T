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

Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16



Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12

Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]