// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите любое число:" );
int numberA = Convert.ToInt32(Console.ReadLine());


if (numberA < 100)
{
    System.Console.WriteLine("Третьей цифры нет");
}

else
{
    while (numberA > 999)
    {
        numberA = numberA / 10;
    }

    System.Console.WriteLine($"Третья цифра числа равна {numberA % 10}");
}

