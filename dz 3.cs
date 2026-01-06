using System;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

namespace С_Metods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("задание 1");
            int b = 0;
            string d = Console.ReadLine();
            if (d == null || d.Equals( string.Empty)==false)
            {
                 if (int.TryParse(d, out int number))
                 {
                    int a = int.Parse(d);
                    int n = Abs(a);
                    Console.WriteLine(n);
                 }
            }

            Console.WriteLine("задание 2");
            Console.WriteLine("введите еще три числа");
            string e = Console.ReadLine();
            if (e == null || e.Equals(string.Empty) == false)
            {
                if (int.TryParse(e, out int number))
                {
                    int h = int.Parse(e);
                    string f = Console.ReadLine();
                    if (f == null || f.Equals(string.Empty) == false)
                    {
                        if (int.TryParse(f, out int numberrr))
                        {
                            int g = int.Parse(f);
                            string yui = Console.ReadLine();
                            if (yui == null || yui.Equals(string.Empty) == false)
                            {
                                if (int.TryParse(yui, out int numberr))
                                {
                                    int w = int.Parse(yui);
                                    int s = Max(w, h, g);
                                    Console.WriteLine(s);
                                }
                            }
                        }
                    }
                }
            }


            Console.WriteLine("задание 3");
            string simbol = Console.ReadLine();
            if (simbol == null || simbol.Equals(string.Empty) == false)
            {
                string counttt = Console.ReadLine();
                if (counttt == null || counttt.Equals(string.Empty) == false)
                {
                    if (int.TryParse(counttt, out int numbe))
                    {
                        int count = int.Parse(counttt);
                        PrintLine(simbol, count);
                    }
                }
            }


            Console.WriteLine("задание 4");
            string text = Console.ReadLine();
            if (text == null || text.Equals(string.Empty) == false)
            {
                string countt = Console.ReadLine();
                if (countt == null || countt.Equals(string.Empty) == false)
                {
                    if (int.TryParse(countt, out int numb))
                    {
                        int times = int.Parse(countt);
                        string v = Repeat(text, times);
                        Console.WriteLine(v);
                    }
                }
            }


            Console.WriteLine("Задание 5");
            string p = Console.ReadLine();
            if (p == null || p.Equals(string.Empty) == false)
            {
                char ch = Console.ReadKey().KeyChar;
                int index = -1;
                bool q = TryIndexOf(p, ch, out index);
                Console.WriteLine(q);
            }


            Console.WriteLine("Задание 6");
            string rt = Console.ReadLine();
            if (rt == null || rt.Equals(string.Empty) == false)
            {
                if (int.TryParse(rt, out int number))
                {
                    int value = int.Parse(rt);
                    string yt = Console.ReadLine();
                    if (yt == null || yt.Equals(string.Empty) == false)
                    {
                        if (int.TryParse(yt, out int numbr))
                        {
                            int min = int.Parse(yt);
                            string ut = Console.ReadLine();
                            if (ut == null || ut.Equals(string.Empty) == false)
                            {
                                if (int.TryParse(ut, out int numer))
                                {
                                    int max = int.Parse(ut);
                                    Clamp(ref value, min, max);
                                }
                            }
                        }
                    }
                }
            }


            Console.WriteLine("Задание 7");
            string f1 = Console.ReadLine();
            if (f1 == null || f1.Equals(string.Empty) == false)
            {
                string f3 = ReverseRec(f1);
                Console.WriteLine(f3);
            }


            Console.WriteLine("Задание 8");
            string n4 = Console.ReadLine();
            if (n4 == null || n4.Equals(string.Empty) == false)
            {
                if (int.TryParse(n4, out int number))
                {
                    int n5 = int.Parse(n4);
                    int ml = SumDigitsRec(n5);
                    Console.WriteLine(ml);
                }
            }


            Console.WriteLine("Задание 9");
            string a2 = Console.ReadLine();
            if (a2 == null || a2.Equals(string.Empty) == false)
            {
                if (int.TryParse(a2, out int number))
                {
                    int a1 = int.Parse(a2);
                    string b2 = Console.ReadLine();
                    if (b2 == null || b2.Equals(string.Empty) == false)
                    {
                        if (int.TryParse(b2, out int numberr))
                        {
                            int b1 = int.Parse(b2);
                            string c2 = Console.ReadLine();
                            if (c2 == null || c2.Equals(string.Empty) == false)
                            {
                                if (int.TryParse(c2, out int numberrr))
                                {
                                    int c1 = int.Parse(c2);
                                    bool hui = IsTriangle(in a1, in b1, in c1);
                                    Console.WriteLine(hui);
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Задание 10");
            string a10 = Console.ReadLine();
            if (a10 == null || a10.Equals(string.Empty) == false)
            {
                if (int.TryParse(a10, out int number))
                {
                    int a9 = int.Parse(a10);
                    string n10 = Console.ReadLine();
                    if (n10 == null || n10.Equals(string.Empty) == false)
                    {
                        if (int.TryParse(n10, out int numberr) == false)
                        {
                            int n9 = int.Parse(n10);
                            int huh = PowFast(a9, n9);
                            Console.WriteLine(huh);
                        }
                    }
                }
            }


            Console.WriteLine("Задание 11");
            string hh = Console.ReadLine();
            if (hh == null || hh.Equals(string.Empty) == false)
            {
                string huihui = CompressRuns(hh);
                Console.WriteLine(huihui);
            }
        }


        static int Abs(int a)
        {
            if (a < 0)
            {
                return -1 * a;
            }
            else
            {
                return a;
            }
        }
        static int Max(int w, int h, int g)
        {
            int ma = w;
            if (ma < h)
            {
                ma = h;
            }
            if (ma < g)
            {
                ma = g;
            }
            return ma;
        }
        static void PrintLine(string simbol = "*", int count =10)
        {
            string s1 = "";
            for (int i1 = 0; i1 < count; i1++)
            {
                s1 += simbol;
            }
            Console.WriteLine(s1);
        }
        static string Repeat(string text, int times = 3)
        {
            string s = "";
            for (int i = 0; i < times; i++)
            {
                s = s + text;
            }
            return s;
        }
        static bool TryIndexOf(string p, char ch, out int index)
        {
            if (p.Contains(ch) == true)
            {
                index = p.IndexOf(ch);
                Console.WriteLine(index);
                return true;
            }
            else
            {
                index = -1;
                Console.WriteLine(index);
                return false;
            }
        }
        static void Clamp(ref int value, int min, int max)
        {
            if (value < min)
            {
                value = min;
            }
            if (value > max)
            {
                value = max;
            }
            Console.WriteLine(value);
        }
        static string ReverseRec(string f1)
        {
            if (f1.Length == 1)
            {
                return f1;
            }
            return ReverseRec(f1.Substring(1))+ f1.Substring(0,1);
        }
        static int SumDigitsRec(int n5)
        {
            if (Abs(n5) < 10)
            {
                return Abs(n5);
            }
            return Abs(n5 % 10) + SumDigitsRec(n5 / 10);
        }
        static bool IsTriangle(in int a1, in int b1, in int c1)
        {
            int[] arr = new int[3];
            arr[0] = a1;
            arr[1] = b1;
            arr[2] = c1;
            Array.Sort(arr);
            if (arr[0] < arr[1] + arr[2])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static int PowFast(int a9, int n9)
        {
            int a9n9 = 1;
            if (n9 == 0)
            {
                a9n9 = 1;
            }
            if (n9 % 2 == 0)
            {
                return PowFast(a9, n9/2) * PowFast(a9, n9/2);
            }
            else
            {
                return a9 * PowFast(a9, (n9 - 1)) / 2;
            }
        }
        static string CompressRuns(string hh)
        {
            string hhh = "";
            for (int i52 = 0; i52 < hh.Length - 2; i52++)
            {
                if (hh[i52] != hh[i52+1])
                {
                    hhh += hh[i52];
                }
            }
            if (hh[hh.Length - 1] != hh[hh.Length - 2])
            {
                hhh += hh[hh.Length - 1];
            }
            return hhh;
        }
    }
}