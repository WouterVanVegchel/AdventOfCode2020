using Advent._2020.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Advent._2020
{
    public class Day01Ex01
    {
        public void Ex01()
        {
            int a;
            int b;
            var lines = FileReaderHelper.GetLines("input01.txt");
            foreach (var line in lines)
            {
                a = Convert.ToInt32(line);
                foreach (var line2 in lines)
                {
                    b = Convert.ToInt32(line2);
                    if (a + b == 2020)
                    {
                        Console.WriteLine($"a = {a} en b = {b}. a x b = {a * b}");
                    }
                }

            }
            Console.ReadLine();
        }

        public void Ex02()
        {
            int a;
            int b;
            int c;
            var lines = FileReaderHelper.GetLines("input01.txt");
            foreach (var line in lines)
            {
                a = Convert.ToInt32(line);
                foreach (var line2 in lines)
                {
                    b = Convert.ToInt32(line2);

                    foreach (var line3 in lines)
                    {
                        c = Convert.ToInt32(line3);
                        if (a + b + c == 2020)
                        {
                            Console.WriteLine($"a = {a} en b = {b} en c = {c}. a x b x c = {a * b * c}");
                        }
                    }

                }

            }
            Console.ReadLine();
        }
    }
}
