using System;
using System.ComponentModel.Design;

namespace pupupu;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("задание нулевое:");
        Console.WriteLine("Hello world");
        Console.WriteLine("Задание первое:");
        float a = 0;
        float b = 0;
        float c = 0;
        float d = 0;
        float e = 0;
        float f = 0;
        float i = 0;
        float p = 0;
        float k = 0;
        float z = 0;
        float r = 0;
        float y = 1;
        float x = 0;
        Console.WriteLine("Введите любое число");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите любое число");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine($"ваше число {a + b}");
        if (a > b)
        {
            Console.WriteLine($"ваше число {a - b}");
        }
        else;
        {
            Console.WriteLine($"ваше число {b - a}");
        }
        Console.WriteLine($"ваше число {a * b}");
        if (a > b)
        {
            if (b != 0)
            {
                Console.WriteLine($" {a / b}");
            }
        }
        else
        {
            if (a != 0)
            {
                Console.WriteLine($"{b / a}");
            }
        }
        Console.WriteLine("Задание второе:");
        c = int.Parse(Console.ReadLine());
        if (c < 12)
        {
            Console.WriteLine("ребенок");
        }
        if (c > 11)
        {
            if (c < 18)
            {
                Console.WriteLine("подросток");
            }
        }
        if (c > 17)
        {
            Console.WriteLine("взрослый");
        }
        Console.WriteLine("задание третье");
        d = int.Parse(Console.ReadLine());
        if (d % 2 == 0)
        {
            Console.WriteLine("четное");
        }
        else
        {
            Console.WriteLine("нечет");
        }
        Console.WriteLine("задание четвертое");
        e = int.Parse(Console.ReadLine());
        if (e % 3 == 0)
        {
            if (e % 5 == 0)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
        else
        {
            Console.WriteLine("no");
        }
        Console.WriteLine("задание пятое");
        f = int.Parse(Console.ReadLine());
        i = f + 1;
        p = (f * i) / 2;
        Console.WriteLine($"ваше число {p}");
        Console.WriteLine("задание шестое");
        z = int.Parse(Console.ReadLine());
        Console.WriteLine($"1*{z}={z * 1}");
        Console.WriteLine($"2*{z}={z * 2}");
        Console.WriteLine($"3*{z}={z * 3}");
        Console.WriteLine($"4*{z}={z * 4}");
        Console.WriteLine($"5*{z}={z * 5}");
        Console.WriteLine($"6*{z}={z * 6}");
        Console.WriteLine($"7*{z}={z * 7}");
        Console.WriteLine($"8*{z}={z * 8}");
        Console.WriteLine($"9*{z}={z * 9}");
        Console.WriteLine($"10*{z}={z * 10}");
        Console.WriteLine("задание седьмое");
        k = int.Parse(Console.ReadLine());
        while (k >= 2)
        {
            y *= k;
            k = k - 1;
        }
        Console.WriteLine($"ваше число {y}");
        Console.WriteLine("задание восьмое");
        string q = "12345";
        string w = Console.ReadLine();
        while (w != q)
        {
            w = Console.ReadLine();
        }
        Console.WriteLine("правильно");
        Console.WriteLine("задание девятое");
        x = int.Parse(Console.ReadLine());
        while (x != 0)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine($" {x}");
            }
            if (x % 3 == 0)
            {
                if (x % 2 != 0)
                {
                    Console.WriteLine($" {x}");
                }
            }
            x = x - 1;
        }

    }
}
