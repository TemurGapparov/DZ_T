// using System;

// public class Answer
// {
//     public static double[,] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom)
//     {
//         double[,] array = new double[n, m];
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array[i, j] = Math.Round(minLimitRandom + new Random().NextDouble() * (maxLimitRandom - minLimitRandom), 1);
//             }
//         }
//         return array;
//     }

//     public static void PrintArray(double[,] matrix)
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write(matrix[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }

//     // Не удаляйте и не меняйте метод Main! 
//     public static void Main(string[] args)
//     {
//         int m, n, minLimitRandom, maxLimitRandom;

//         if (args.Length >= 4)
//         {
//             m = int.Parse(args[0]);
//             n = int.Parse(args[1]);
//             minLimitRandom = int.Parse(args[2]);
//             maxLimitRandom = int.Parse(args[3]);

//             double[,] array = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);

//             // Выберем случайные индексы трех элементов матрицы array
//             int row1 = new Random().Next(0, m);
//             int col1 = new Random().Next(0, n);
//             int row2 = new Random().Next(0, m);
//             int col2 = new Random().Next(0, n);
//             int row3 = new Random().Next(0, m);
//             int col3 = new Random().Next(0, n);

//             // Проверяем, являются ли выбранные элементы дробными числами
//             bool isFractional1 = (array[row1, col1] % 1) != 0;
//             bool isFractional2 = (array[row2, col2] % 1) != 0;
//             bool isFractional3 = (array[row3, col3] % 1) != 0;

//             // Если два из трех элементов не являются дробными числами, то бросаем исключение
//             if ((isFractional1 && isFractional2) || (isFractional1 && isFractional3) || (isFractional2 && isFractional3))
//             {
//                 Console.WriteLine("Все ок!");
//             }
//             else
//             {
//                 throw new Exception("Выбранные элементы не содержат по крайней мере два дробных числа.");
//             }
//         }
//         else
//         {
//             m = 3;
//             n = 4;
//             minLimitRandom = -10;
//             maxLimitRandom = 10;

//             double[,] result = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
//             PrintArray(result);
//         }
//     }
// }

// using System;

// public class Answer
// {
//     public static void PrintArray(int[,] matrix)
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write(matrix[i, j] + "\t");
//             }
//             Console.WriteLine();
//         }
//     }

//     public static int[,] CreateIncreasingMatrix(int n, int m, int k)
//     {
//         int[,] array = new int[n, m];
//         int count = 1;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 if (i == 0 && j == 0) array[i, j] = 1;
//                 else array[i, j] = count + k;
//                 count = array[i, j];
//             }
//         }
//         return array;
//     }

//     public static int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
//     {
//         int[] arrayfind = new int[2];
//         if (matrix.GetLength(0) >= rowPosition && matrix.GetLength(1) >= columnPosition) arrayfind[0] = matrix[rowPosition - 1, columnPosition - 1];
//         return arrayfind;
//     }

//     public static void PrintCheckIfError(int[] results, int X, int Y)
//     {
//         if (results[0] == 0) Console.WriteLine("There is no such index");
//         else Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");

//     }


//     // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args)
//     {
//         int n, m, k, x, y;

//         if (args.Length >= 5)
//         {
//             n = int.Parse(args[0]);
//             m = int.Parse(args[1]);
//             k = int.Parse(args[2]);
//             x = int.Parse(args[3]);
//             y = int.Parse(args[4]);
//         }
//         else
//         {
//             // Здесь вы можете поменять значения для отправки кода на Выполнение
//             n = 3;
//             m = 4;
//             k = 2;
//             x = 5;
//             y = 3;
//         }

//         // Не удаляйте строки ниже
//         int[,] result = CreateIncreasingMatrix(n, m, k);
//         PrintArray(result);
//         PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
//     }
// }

// using System;

// public class Answer
// {
//     public static void PrintArray(int[,] matrix)
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write(matrix[i, j] + "\t");
//             }
//             Console.WriteLine();
//         }
//     }

//     public static int[,] CreateIncreasingMatrix(int n, int m, int k)
//     {
//         int[,] array = new int[n, m];
//         int count = 1;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 if (i == 0 && j == 0) array[i, j] = 1;
//                 else array[i, j] = count + k;
//                 count = array[i, j];
//             }
//         }
//         return array;
//     }

//     static void PrintListAvr(double[] list)
//     {
//         Console.WriteLine($"The averages in columns are: ");
//         foreach (double i in list) Console.Write($"{Math.Round(i, 2):f2}\t");
//     }

//     static double[] FindAverageInColumns(int[,] matrix)
//     {
//         double[] arr = new double[matrix.GetLength(1)];
//         for (int i = 0; i < arr.Length; i++)
//         {
//             for (int j = 0; j < matrix.GetLength(0); j++)
//             {
//                 arr[i] += matrix[j, i];
//             }
//             arr[i] /= matrix.GetLength(0);
//         }
//         return arr;
//     }


//     // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args)
//     {
//         int n, m, k;

//         if (args.Length >= 3)
//         {
//             n = int.Parse(args[0]);
//             m = int.Parse(args[1]);
//             k = int.Parse(args[2]);
//         }
//         else
//         {
//             // Здесь вы можете поменять значения для отправки кода на Выполнение
//             n = 3;
//             m = 4;
//             k = 2;
//         }

//         // Не удаляйте строки ниже
//         int[,] result = CreateIncreasingMatrix(n, m, k);
//         PrintArray(result);
//         PrintListAvr(FindAverageInColumns(result));
//     }
// // }

// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// using System;

// public class Answer
// {
//     public static void PrintArray(int[,] matrix)
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write(matrix[i, j] + "\t");
//             }
//             Console.WriteLine();
//         }
//     }

//     public static int[,] FillArrar(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array[i, j] = new Random().Next(10);
//             }
//         }
//         return array;
//     }

//     static public int[,] ReplacArray(int[,] matrix)
//     {
//         // int[] arr = new int[matrix.GetLength(1)];
//         int num = 0;
//         for (int i = 0; i < matrix.GetLength(1); i++)
//         {
//             // arr[i] = matrix[0, i];
//             num = matrix[0, i];
//             matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
//             // matrix[matrix.GetLength(0) - 1, i] = arr[i];
//             matrix[matrix.GetLength(0) - 1, i] = num;
//         }
//         return matrix;
//     }
//     static public void Main(string[] args)
//     {
//         int n, m;

//         if (args.Length >= 2)
//         {
//             n = int.Parse(args[0]);
//             m = int.Parse(args[1]);
//         }
//         else
//         {
//             n = 7;
//             m = 4;
//         }

//         // Не удаляйте строки ниже
//         int[,] result = FillArrar(new int[n, m]);
//         PrintArray(result);
//         Console.WriteLine();
//         PrintArray(ReplacArray(result));
//     }


// }

// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.

// using System;

// public class Answer
// {
//     public static void PrintArray(int[,] matrix)
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write(matrix[i, j] + "\t");
//             }
//             Console.WriteLine();
//         }
//     }

//     public static int[,] FillArrar(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array[i, j] = new Random().Next(10);
//             }
//         }
//         return array;
//     }

//     static public int[,] ReplacArray(int[,] matrix)
//     {
//         int[,] arr = new int[matrix.GetLength(1), matrix.GetLength(1)];
//         for (int i = 0; i < matrix.GetLength(1); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 arr[i, j] = matrix[j, i];
//             }
//         }
//         return arr;
//     }
//     static public void Main(string[] args)
//     {
//         int n, m;

//         if (args.Length >= 2)
//         {
//             n = int.Parse(args[0]);
//             m = int.Parse(args[1]);
//         }
//         else
//         {
//             n = 4;
//             m = 4;
//         }

//         // Не удаляйте строки ниже
//         if (n == m)
//         {
//             int[,] result = FillArrar(new int[n, m]);
//             PrintArray(result);
//             Console.WriteLine();
//             PrintArray(ReplacArray(result));
//         }
//         else
//         {
//             Console.WriteLine("Количество строк и сталбцов не совподает");
//         }

//     }


// }

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// using System;

// public class Answer
// {
//     public static void PrintArray(int[,] matrix)
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write(matrix[i, j] + "\t");
//             }
//             Console.WriteLine();
//         }
//     }

//     public static int[,] FillArrar(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array[i, j] = new Random().Next(10);
//             }
//         }
//         return array;
//     }

//     static public int[,] ReplacArray(int[,] matrix)
//     {
//         // int[,] arr = new int[matrix.GetLength(0), matrix.GetLength(1)];
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             int num = -1;
//             int num1 = -1;
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 int x = 0;
//                 for (int k = j; k < matrix.GetLength(1); k++)
//                 {
//                     if (matrix[i, k] > num)
//                     {
//                         num = matrix[i, k];
//                         x = k;
//                     }
//                 }
//                 num1 = matrix[i, j];
//                 matrix[i, j] = num;
//                 matrix[i, x] = num1;
//                 num = -1;
//                 num1 = -1;
//             }
//         }
//         return matrix;
//     }
//     static public void Main(string[] args)
//     {
//         int n, m;

//         if (args.Length >= 2)
//         {
//             n = int.Parse(args[0]);
//             m = int.Parse(args[1]);
//         }
//         else
//         {
//             n = 4;
//             m = 6;
//         }

//         // Не удаляйте строки ниже
//         int[,] result = FillArrar(new int[n, m]);
//         PrintArray(result);
//         Console.WriteLine();
//         PrintArray(ReplacArray(result));

//     }
// }

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// using System;

// public class Answer
// {
//     public static void PrintArray(int[,] matrix)
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write(matrix[i, j] + "\t");
//             }
//             Console.WriteLine();
//         }
//     }

//     public static int[,] FillArrar(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array[i, j] = new Random().Next(10);
//             }
//         }
//         return array;
//     }

//     static public int ReplacArray(int[,] matrix)
//     {
//         int[] arr = new int[matrix.GetLength(0)];
//         int num = 0;
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             int count = 0;
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 count += matrix[i, j];
//             }
//             arr[i] = count;
//         }
//         for (int i = 0; i < arr.Length; i++)
//         {
//             // Console.WriteLine(arr[i]);
//             if (arr.Min() == arr[i])
//             {
//                 num = i + 1;
//                 break;
//             }
//         }
//         return num;
//     }
//     static public void Main(string[] args)
//     {
//         int n, m;

//         if (args.Length >= 2)
//         {
//             n = int.Parse(args[0]);
//             m = int.Parse(args[1]);
//         }
//         else
//         {
//             n = 4;
//             m = 2;
//         }

//         // Не удаляйте строки ниже
//         int[,] result = FillArrar(new int[n, m]);
//         PrintArray(result);
//         Console.WriteLine();
//         Console.WriteLine(ReplacArray(result));

//     }
// }
