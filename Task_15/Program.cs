// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();

Console.WriteLine("Проверим, является ли введенный Вами номер дня недели выходным днем?");

int number = int.Parse(Console.ReadLine()!);

string report = "является рабочим";

if ((number == 7) || (number == 6)) 
{
    report = "является выходным";
}
else if ((number > 7) || (number < 1))
{
    report = "не является днём недели";
}

Console.WriteLine($"День с номером {number} {report}");
