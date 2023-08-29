// Console.WriteLine("Введите число");
// int x = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i < x + 1; i++)
// {
//     Console.Write(i * i + " ");
// }

// using System;

// public class Answer
// {
//     static bool IsPalindrome(int number)
//     {
//         // Введите свое решение ниже
//         bool x = true;
//         string str = number.ToString();
//         if (number >= 99999 || number <= 10000)
//         {
//             Console.Write("Число не пятизначное ");
//             x = false;
//         }
//         else
//         {
//             // if (number / 10000 != number % 10 || ((number / 1000) - (number / 10000) * 10) != (number % 100 - number % 10) / 10)

//             if (str[0] != str[4] || str[1] != str[3])
//             {
//                 x = false;
//             }

//         }
//         return x;
//     }

//     // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args)
//     {
//         int number;

//         if (args.Length >= 1)
//         {
//             number = int.Parse(args[0]);
//         }
//         else
//         {
//             // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 63536;
//         }

//         // Не удаляйте строки ниже
//         bool result = IsPalindrome(number);
//         System.Console.WriteLine($"{result}");
//     }
// }

// using System;

// public class Answer
// {
//     static void ShowCube(int N)
//     {
//         // Введите свое решение ниже
//         for (int i = 1; i <= N; i++)
//         {
//             Console.WriteLine(Math.Pow(i, 3));
//         }

//     }

//     // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args)
//     {
//         int N;

//         if (args.Length >= 1)
//         {
//             N = int.Parse(args[0]);
//         }
//         else
//         {
//             // Здесь вы можете поменять значения для отправки кода на Выполнение
//             N = 6;
//         }

//         // Не удаляйте строки ниже
//         ShowCube(N);
//     }
// }

// int[] array = { 5, 9, 8, 10, 6, 3, 2, 8, 4 };

// void PrintArr(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int maxPosotion = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] > array[maxPosotion])
//             {
//                 maxPosotion = j;
//             }
//         }
//         int temporary = array[i];
//         array[i] = array[maxPosotion];
//         array[maxPosotion] = temporary;
//     }
// }

// SelectionSort(array);
// PrintArr(array);