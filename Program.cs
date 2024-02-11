#nullable enable
using System;
namespace webadd_Khoyskiy;

class Program
{
    static void task1()
    {
        Console.WriteLine("Task1 !");
        Console.Write("Площа s = ");
        string? str = Console.ReadLine();
        float s = 0;
        if (str != null) s = float.Parse(str);
        double r = Math.Sqrt(s / Math.PI);
        Console.WriteLine("r=" + r);
    }
    static void task2()
    {
        Console.WriteLine("Task2 !");
        Console.Write("Введiть трьох значне число:  ");
        string? str = Console.ReadLine();
        int s1 = 0, s3 = 0;  
        if(str != null && str.Length == 3)
        {
            char firstChar = str[0];
            char thirdChar = str[2];
            s1 = int.Parse(firstChar.ToString());
            s3 = int.Parse(thirdChar.ToString());
            if (s1 > s3) Console.WriteLine("Перша цифра бiльша");
            else if (s1 < s3) Console.WriteLine("Остання цифра бiльша");
            else Console.WriteLine("Цифри рiвнi");
        }
        else Console.WriteLine("Число не трьох значне");
    }
    static void task3()
    {
        Console.WriteLine("Task3 !");
        Console.Write("Введiть x та y:  ");
        string? strx = Console.ReadLine();

        float x = 0, y = 0;
        if (strx != null)
        {
            x = float.Parse(strx);
        }
        string? stry = Console.ReadLine();
        if (stry != null)
        {
            y = float.Parse(stry);
        }
        if(x >= -23 && x<=0 && y >= -23 && y <= 0)
        {
            if( x == -23 || y == 0 || x == y) { Console.WriteLine("На межi"); }
            else if (y > x) { Console.WriteLine("Так"); }
            else { Console.WriteLine("Нi"); }
        }
        else { Console.WriteLine("Нi"); }
    }
    static void task4()
    {
        Console.Write("year=");
        int y = int.Parse(Console.ReadLine());
        int animalIndex = (y - 4) % 12;
        Console.WriteLine(animalIndex switch
        {
            0 => "Щур",
            1 => "Бик",
            2 => "Тигр",
            3 => "Кролик",
            4 => "Дракон",
            5 => "Змія",
            6 => "Кінь",
            7 => "Коза",
            8 => "Мавпа",
            9 => "Півень",
            10 => "Собака",
            11 => "Кабан",
            _ => "Помилка"
        });
    }
    static double Square(double a, double b)
    {
        double x = a - b;
        double result = Math.Pow(x, 2);
        return result;
    }
    static void task6()
    {
        Console.WriteLine("Введiть перше число:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введiть друге число:");
        double b = Convert.ToDouble(Console.ReadLine());
        double result = (1 / (Math.Pow(a, 2) + a * b + 1)) - (1 / (Math.Pow(b, 2) + a * b + 1));
        Console.WriteLine("Answer "+ result);
    }

static void Main(string[] args)
    {
        Console.WriteLine("Lab 1 !");
        task1();
        task2();
        task3();
        task4();
        Console.WriteLine("Введiть перше число:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введiть друге число:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = Square(num1, num2);

        Console.WriteLine($"Квадрат рiзницi мiж {num1} i {num2} дорiвнює {result}");
        task6();
        Console.ReadLine();
    }
}
