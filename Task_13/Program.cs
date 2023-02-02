//Задача 13: Напишите программу, которая выводит 
//третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

Console.Clear();

Console.WriteLine("Будем искать третью цифру числа. Введите произвольное число");

int number = int.Parse(Console.ReadLine()!);

int result = 0;
int tmpnumber;

if (number < 100)
{
    Console.WriteLine($"В числе {number} третьей цифры нет.");
}
else
{
    if (number < 1000)
    {   
        result = (number % 10);    
    }

    else
    {
        tmpnumber = number;
        while(tmpnumber >= 1000)
        {
            tmpnumber = tmpnumber / 10;           
        }

        result = tmpnumber % 10;  
    }

    Console.WriteLine($"Третья цифра числа {number}: {result}");
}