// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Write("Введите любое число:");
int numberA = Convert.ToInt32(Console.ReadLine());


if (numberA > 1000)
{
    System.Console.WriteLine($"Третья цифра числа равна {numberA % 1000/100}");
}

if (numberA < 100)
{
    System.Console.WriteLine("Третьей цифры нет");
}
else if (numberA >= 100 && numberA < 1000)
{
    System.Console.WriteLine($"Третья цифра числа равна {numberA % 10}");
}
