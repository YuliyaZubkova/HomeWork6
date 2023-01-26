// Не используя рекурсию выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи 0 и 1
// Если N = 5 -> 0 1 1 2 3


//получение числа с консоли c проверкой
int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }
    return result; 
}

int number = GetNumber("Введите число N ");
int fib1 = 0;
int fib2 = 1;
int sum = 0;

Console.Write($"{fib1} {fib2}");
for (int i = 0; i < number-2; i++)
{
    sum = fib1 + fib2;
    fib1 = fib2;
    fib2 = sum;
    Console.Write($" {sum}");
}