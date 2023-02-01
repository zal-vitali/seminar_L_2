//Задача 10: Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();

Console.WriteLine("Введите трёхзначное число:");

int number = int.Parse(Console.ReadLine()!);

int result;

if (number < 100 || number > 999)
{
   Console.WriteLine("Введённое число не является трёхзначным"); 
}
else
{
    result = ((number / 10) % 10);
    Console.WriteLine($"Вторая цифра числа {number}: {result}");
}
