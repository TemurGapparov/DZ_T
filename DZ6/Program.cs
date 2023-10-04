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

// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// void Random(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(123);
//     }
// }

// int Array(int[] array)
// {
//     int num = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i].ToString().Length == 2) num+=1;
//     }
//     return num;
// }

// int[] array = new int[123];

// Random(array);


// Console.WriteLine($"[{String.Join(", ", array)}] -> {Array(array)}");

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй 
// и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// void Random(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(99);
//     }
// }

// int[] Arrya(int[] array)
// {
//     if (array.Length % 2 == 0)
//     {
//         int[] list = new int[array.Length / 2];
//         for (int i = 0; i < array.Length / 2; i++)
//         {

//             list[i] = array[i] + array[array.Length - i - 1];
//         }
//         return list;
//     }
//     else
//     {
//         int[] list = new int[array.Length / 2 + 1];
//         for (int i = 0; i < Math.Ceiling((double) array.Length / 2); i++)
//         {

//             // Console.WriteLine(Math.Floor((decimal) array.Length / 2));
//             if (i == (array.Length / 2))
//             {
//                 list[i] = array[i];
//             }
//             else
//             {
//                 list[i] = array[i] + array[array.Length - i - 1];
//             }
//         }
//         return list;
//     }
// }

// int[] array = new int[Convert.ToInt32(Console.ReadLine())];
// Random(array);

// int[] q   = new int[(int) Math.Ceiling((decimal) array.Length / 2)];
// Console.WriteLine($"{String.Join(" ", q)}");


// Console.WriteLine($"[{String.Join(" ", array)}] -> {String.Join(" ", Arrya(array))}");

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// void Random(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
// }

// int Count(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] % 2 == 0)
//         {
//             count += 1;
//         }
//     }
//     return count;
// }

// int[] array = new int[Convert.ToInt32(Console.ReadLine())];
// Random(array);

// Console.WriteLine($"[{String.Join(", ", array)}] -> {Count(array)}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// void Random(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-10, 10);
//     }
// }

// int Sum(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 != 0)
//         {
//             count += array[i];
//         }
//     }
//     return count;
// }

// int[] array = new int[Convert.ToInt32(Console.ReadLine())];
// Random(array);

// Console.WriteLine($"[{String.Join(", ", array)}] -> {Sum(array)}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

void Random(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * 20, 2);
    }
}

double[] Count(double[] array)
{
    double[] arr = new double[2];
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    arr[0] = max;
    arr[1] = min;
    return arr;
}

double[] array = new double[Convert.ToInt32(Console.ReadLine())];
Random(array);
double[] arrq = Count(array);


Console.WriteLine($"[{String.Join(", ", array)}] -> {arrq[0]} - {arrq[1]} = {Math.Round(arrq[0] - arrq[1], 2)}");

