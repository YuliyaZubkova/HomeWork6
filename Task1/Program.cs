/* Задача 39: Напишите программу, которая перевернет одномерный массив
(последний элемент будет на первом месте, а первый - на последнем и т.п.)
[1, 2, 3, 4, 5] -> [5, 4, 3, 2, 1]
*/

/*  1. метод, который будет выдавать заполненный случайными числами массив
    2. метод, который будет печатать массив
    3. получение числа с консоли для того, чтобы задать размерность массива
    4. метод, который будет переворачивать массив
*/

// Метод, который будет выдавать заполненный случайными числами массив
int[] InitArray(int dimension)
{
    int[] array = new int [dimension];
    Random rnd = new Random();
    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(1,9);
    }
    return array;
}

// Метод, который будет печатать массив
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

// Получение числа с консоли для того, чтобы задать размерность массива
int GetNumberFromConsole(string message)
{
    bool isCorrect = false; 
    int result = 0;

    while (!isCorrect)
        {
            Console.WriteLine(message);

            if(int.TryParse(Console.ReadLine(), out result))
            {
                isCorrect = true;
            }
            else 
            {
                Console.WriteLine("Ввели не число. Введите число");
            }
        }

    return result;
}

// Метод, который будет переворачивать массив 
//(в C# есть метод Array.Reverse())
//Array.Reverse(resultArray)
//PrintArray(resultArray)
int [] ReverseArray(int[] array)
{
    int[] result = new int[array.Length];
    int count = 0;

    for (int i = array.Length - 1; i >= 0; i--)
    {
        result[count] = array[i];
        count++;
    }

    return result;
}
int dimension = GetNumberFromConsole("Введите размерность массива ");
int[] startArray = InitArray(dimension);
PrintArray(startArray);
int[] resultArray = ReverseArray(startArray);
PrintArray(resultArray);
