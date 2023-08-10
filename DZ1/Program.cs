Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
string i = Console.ReadLine();
int number = Convert.ToInt32(i);

int result = number * number;
Console.WriteLine("Наш результат: " + result);