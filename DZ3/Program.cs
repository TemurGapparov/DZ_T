// Random rand = new Random();
// int n = rand.Next(10, 100);

// int a = n / 10;
// int b = n % 10;

// Console.WriteLine(n);

// if (a > b)
// {
//     Console.WriteLine("максимальное число a = " + a);
// }
// else if (a < b)
// {
//     Console.WriteLine("максимальное {1} число b = {0} ",b,a);
// }
// else
// {
//     Console.WriteLine($"максимальное число {a} = {b} ");
// }

// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

// int number = new Random().Next(100, 1000);

// int a = number / 100 * 10;
// int b = number % 10;

// Console.WriteLine(number);
// Console.WriteLine(a + b);


// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (a == b * b && b == a * a)
{
    Console.WriteLine("Da");
}
else
{
    Console.WriteLine("Net");
}