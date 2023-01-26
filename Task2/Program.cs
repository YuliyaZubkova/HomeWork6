// Программа, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник такой длины.
// Теорема: Каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numberThree = Convert.ToInt32(Console.ReadLine());

if (numberOne < numberTwo + numberThree && 
    numberTwo < numberOne + numberThree &&
    numberThree < numberOne + numberTwo) 
    Console.WriteLine("Да");
else Console.WriteLine("Нет");
