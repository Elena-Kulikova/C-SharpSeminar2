// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8 
// 918 -> 1

Console.Write("Введите число a:");
int numberA = Convert.ToInt32(Console.ReadLine()); 

if (numberA > 99 && numberA < 1000 )
{
    System.Console.WriteLine($"Вторая цифра числа равна {numberA / 10 % 10}");
}
else
{
    System.Console.WriteLine("Введеное число не является трёхзначным");
}

