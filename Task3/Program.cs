// Программа, которая преобразовывает десятичное число в двоичное.

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();

int fromBase = 10;
int toBase = 2;

string result = Convert.ToString(Convert.ToInt32(number, fromBase), toBase);

Console.WriteLine($"Число {number} десятичной системы в двоичной системе будет числом: {result}");

