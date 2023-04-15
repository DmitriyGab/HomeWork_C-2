// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трехзначное число");
// int number1 = Convert.ToInt32(Console.ReadLine());

// if (number1 > 99 && number1 < 1000)
// {
//     int x1 = number1 / 10;
//     int x2 = x1 % 10;
    
//     Console.WriteLine("Второе числое - " +x2);
// }
// else
// {
//     Console.WriteLine("Указанное число не является трехзначным");
// }


// Задача 13: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число");
// int number1 = Convert.ToInt32(Console.ReadLine());


// if (number1 > 99)
// {
//     while (number1 > 999)
//         {
//         number1 = number1 / 10;
//         }
           
//     int x2 = number1 % 10;
//     Console.WriteLine("Третье числое: "  +x2);
// }

// else if (number1 < -99)
// {
//     while (number1 < -999)
//         {
//         number1 = number1 / 10;
//         }
        
//         int x2 = number1 % 10;
//         Console.WriteLine("Третье числое: "  +x2);
// }
 
// else if (number1 > 10 && number1 < 100)
// {
//     Console.WriteLine($"У числа {number1} не имеется третьей цифры");
// }

// else if (number1 < -10 && number1 > -100)
// {
//     Console.WriteLine($"У числа {number1} не имеется третьей цифры");
// }

// else
// {
//     Console.WriteLine($"У числа {number1} не имеется третьей цифры");
// }



// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число, соответствующее дню недели");
int dayWeek = Convert.ToInt32(Console.ReadLine());

if (dayWeek > 0 && dayWeek < 8)
{
    if (dayWeek == 1)
    {
    Console.WriteLine($"Понедельник (день № {dayWeek}) - не является выходным днём");
    }
    
    else if (dayWeek == 2)
    {
    Console.WriteLine($"Вторник (день № {dayWeek}) - не является выходным днём");
    }

    else if (dayWeek == 3)
    {
    Console.WriteLine($"Среда (день № {dayWeek}) - не является выходным днём");
    }

    else if (dayWeek == 4)
    {
    Console.WriteLine($"Четверг (день № {dayWeek}) - не является выходным днём");
    }

    else if (dayWeek == 5)
    {
    Console.WriteLine($"Пятница (день № {dayWeek}) - не является выходным днём");
    }

    else if (dayWeek == 6)
    {
    Console.WriteLine($"Суббота (день № {dayWeek}) - выходной день");
    }

    else if (dayWeek == 7)
    {
    Console.WriteLine($"Воскресенье (день № {dayWeek}) - выходной день");
    }
}

else 
{
Console.WriteLine($"Введенное число {dayWeek} выходит за пределы возможного дня недели");
}