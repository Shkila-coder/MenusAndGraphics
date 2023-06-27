using System;
using Lab6_2;

internal abstract class Program
{
    public static void Main(string[] args)
    {
        Date date = new Date(1, 1, 2004);
        Console.WriteLine("Исходные данные: " + date);
        //Console.WriteLine(date);
        Console.WriteLine("Следующий день: " + date.Next());
        Console.WriteLine("Предыдущий день: " + date.Prev());
        Console.WriteLine("Дата на 10 дней позже: " + (date + 10));
        Console.WriteLine("Дата на 10 дней раньше: " + (date - 10));
        Console.WriteLine("Год в дате " + date + " високосный? - " + date.IsLeapYear());
        Console.WriteLine("Обработчик ошибок: " + (date + new Date(10, 0, 0)));
    }    
}

