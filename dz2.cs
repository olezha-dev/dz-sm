using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace pupupu;

internal class Program
{
    static void Main(string[] args)
    {
        float s = 0;
        float e = 0;
        float u = 0;

        float b = 0;
        int d = 0;
        int w = 0;
        float o1 = 0;
        int f = 0;
        float g = 0;
        int ass = 0;
        int assa = 0;
        int p = 0;
        int s1 = 0;
        int d1 = 0;
        float l = 0;
        int asss = 0;
        string h = "";
        int m = 0;
        int mn = 99;
        int s5 = 0;
        int s2 = 0;
        int d2 = 0;
        int asw = 0;
        int asww = 0;
        Console.WriteLine("задание первое ");
        string x = Console.ReadLine();
        s = int.Parse(x);
        s = s + 100;
        Console.WriteLine($"ваше число {s}");
        Console.WriteLine("задание второе ");
        u = (float)(double)(7 / 2);
        e = (int)(7.0 / 2);
        if (u > e)
        {
            Console.WriteLine($" число {u} больше числв {e}");
        }
        if (e > u)
        {
            Console.WriteLine($" число {e} больше числв {u}");
        }
        else
        {
            Console.WriteLine("результаты равны ");
        }
        Console.WriteLine("задание третье ");
        string o = Console.ReadLine();
        if (int.TryParse(o, out w))
        {
            o1 = int.Parse(o);
            Console.WriteLine($"ваше число {o1 * o1}");
        }
        else
        {
            Console.WriteLine("ошибка ввода");
        }
        Console.WriteLine("задание четвертое ");
        string k = Console.ReadLine();
        double ki = Convert.ToDouble(k);
        int a = (int)ki;
        Console.WriteLine($"ваше число {ki - a}");
        Console.WriteLine("задание пятое ");
        int[] ages = new int[5];
        for (int i = 0; i < ages.Length; i++)
        {
            string c = Console.ReadLine();
            d = int.Parse(c);
            ages[i] = d;
        }
        for (int i1 = 0; i1 < ages.Length; i1++)
        {
            h += ages[i1];
        }
        Console.WriteLine(h);
        Console.WriteLine("задание шестое ");
        Console.WriteLine("дан массив с вместимостью 4 и числами 3,7,4,5 ");
        int[] ageses = new int[4] { 3, 7, 4, 5 };
        for (int i2 = 0; i2 < ageses.Length; i2++)
        {
            if (ageses[i2] % 2 == 0)
            {
                f += 1;
            }
        }
        Console.WriteLine($"количество четных в массиве: {f}");
        Console.WriteLine("задание седьмое ");
        int[] ageseses = new int[4] { 3, 7, 4, 5 };
        for (int i3 = 0; i3 < ageseses.Length; i3++)
        {
            g += ageseses[i3];
        }
        Console.WriteLine(g);
        Console.WriteLine(g / ageseses.Length);
        Console.WriteLine("задание восьмое ");
        int[] ageseseses = new int[4] { 3, 7, 4, 5 };
        f = ageseseses[0];
        ageseseses[0] = ageseseses[ageseseses.Length - 1];
        ageseseses[ageseseses.Length - 1] = f;
        for (int i4 = 0; i4 < ageseseses.Length; i4++)
        {
            Console.WriteLine(ageseseses[i4]);
        }
        Console.WriteLine("задание девятое ");
        int[] ag = new int[4] { 3, 7, 4, 5 };
        for (int i5 = 0; i5 < ag.Length; i5++)
        {
            if (ag[i5] > m)
            {
                m = ag[i5];
                asww = i5;
            }
            if (ag[i5] < mn)
            {
                mn = ag[i5];
                asw = i5;
            }
            Console.WriteLine(m);
            Console.WriteLine(asww);
            Console.WriteLine(mn);
            Console.WriteLine(asw);
        }
        Console.WriteLine("задание десятое ");
        int[] agi = new int[10];
        agi[0] = 3;
        agi[1] = 7;
        agi[2] = 5;
        agi[3] = 6;
        agi[4] = 4;
        string x5 = Console.ReadLine();
        s5 = int.Parse(x5);
        agi[agi.Length - 1] = s5;
        if (agi.Count() == 10)
        {
            int[] agii = new int[20];
            for (int i45 = 0; i45 < agi.Length; i45++)
            {
                agii[i45] = agi[i45];
            }
            for (int i46 = 0; i46 < agii.Length; i46++)
            {
                Console.WriteLine(agii[i46]);
            }
        }
        for (int i47 = 0; i47 < agi.Length; i47++)
        {
            Console.WriteLine(agi[i47]);
        }
        Console.WriteLine("задание 11 ");
        ass = int.Parse(Console.ReadLine());
        int[] aga = new int[4] { 3, 7, 4, 5 };
        for (int i6 = ass; i6 < aga.Length - 1; i6++)
        {
            aga[i6] = aga[i6 + 1];
        }
        for (int i7 = 0; i7 < aga.Length - 1; i7++)
        {
            Console.WriteLine(aga[i7]);
        }
        Console.WriteLine("задание двенадцатое ");
        asss = int.Parse(Console.ReadLine());
        int[] agas = new int[4] { 3, 7, 4, 5 };
        agas[asss] = agas[agas.Length - 1];
        for (int i15 = ass + 1; i15 < agas.Length - 1; i15++)
        {
            agas[i15] = agas[i15 + 1];
        }
        for (int i16 = 0; i16 < agas.Length - 1; i16++)
        {
            Console.WriteLine(agas[i16]);
        }
        Console.WriteLine("задание тринадцатое ");
        int[] agg = new int[5] { 3, 7, 4, 5, 7 };
        assa = int.Parse(Console.ReadLine());
        for (int i7 = 0; i7 < agg.Length; i7++)
        {
            if (agg[i7] == assa)
            {
                for (int i8 = assa; i8 < agg.Length + 1; i8++)
                {
                    agg[i8] = agg[i8 + 1];
                }
            }
            Console.WriteLine(agg[i7]);
        }
        Console.WriteLine("задание четырнадцатое ");
        int[] egg = new int[4] { 3, 7, 4, 5 };
        int[] ega = new int[egg.Length];
        for (int i0 = egg.Length - 1; i0 >= 0; i0--)
        {
            ega[p] = egg[i0];
            p = p + 1;
        }
        for (int i11 = 0; i11 < ega.Length; i11++)
        {
            Console.WriteLine(ega[i11]);
        }
        Console.WriteLine("задание пятнадцатое ");
        string x1 = Console.ReadLine();
        s1 = int.Parse(x1);
        int[] ege = new int[s1];
        for (int i12 = 0; i12 < ege.Length; i12++)
        {
            string c1 = Console.ReadLine();
            d1 = int.Parse(c1);
            ege[i12] = d1;
        }
        if (s1 % 2 == 0)
        {
            for (int i13 = 0; i13 < (ege.Length / 2); i13++)
            {
                if (ege[i13] != ege[ege.Length - (ege[i13] + 1)])
                {
                    Console.WriteLine("задание не палиндром ");
                    break;
                }
                else
                {
                    l += 1;
                }
            }
            if (l == (ege.Length / 2))
            {
                Console.WriteLine(" палиндром ");
            }
        }
        if (s1 % 2 != 0)
        {
            for (int i14 = 0; i14 < (ege.Length - 1 / 2); i14++)
            {
                if (ege[i14] != ege[ege.Length - ege[i14]])
                {
                    Console.WriteLine("задание не палиндром ");
                    break;
                }
                else
                {
                    l += 1;
                }
            }
            if (l == (ege.Length - 1 / 2))
            {
                Console.WriteLine(" палиндром ");
            }
        }
        Console.WriteLine("задание шестнадцатое ");
        Console.WriteLine("введите объем массива и его составляющие: ");
        string x2 = Console.ReadLine();
        s2 = int.Parse(x2);
        int[] eges = new int[s2];
        for (int i19 = 0; i19 < eges.Length; i19++)
        {
            string c2 = Console.ReadLine();
            d2 = int.Parse(c2);
            eges[i19] = d2;
        }
        for (int i20 = 1; i20 < eges.Length; i20++)
        {
            if (eges[i20] == eges[i20 - 1])
            {
                for (int i21 = eges[i20]; i21 < eges.Length; i21++)
                {
                    eges[i21] = agg[i21 + 1];
                }

            }
        }
        for (int i22 = 0; i22 < eges.Length; i22++)
        {
            Console.WriteLine(eges[i22]);
        }
    }
}
