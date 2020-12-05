using Advent._2020.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Advent._2020
{
    public class Day02
    {
        public void Ex01()
        {
            int count = 0;
            var lines = FileReaderHelper.GetLines("input02.txt");
            foreach (var line in lines)
            {
                // 13-16 k: kkkkkgmkbvkkrskhd
                var parts = line.Split(" ");
                var startNumber = Convert.ToInt32(parts[0].Split("-")[0].Trim()); //13
                var endNumber = Convert.ToInt32(parts[0].Split("-")[1]);//16
                var letter = Convert.ToChar(parts[1].Trim().Remove(parts[1].Trim().Length - 1));//k
                var password = parts[2].Trim();//kkkkkgmkbvkkrskhd
                int freq = password.Count(f => f == letter);
                if (startNumber <= freq && freq <= endNumber)
                {
                    Console.WriteLine(line);
                    count++;
                }
            }
            Console.WriteLine($"aantal regels: {lines.Count}, aantal juiste wachtwoorden: {count}.");
            Console.ReadLine();
        }

        public void Ex02()
        {
            int count = 0;
            var lines = FileReaderHelper.GetLines("input02.txt");
            foreach (var line in lines)
            {
                // 13-16 k: kkkkkgmkbvkkrskhd
                var parts = line.Split(" ");
                var startNumber = Convert.ToInt32(parts[0].Split("-")[0].Trim()); //13
                var endNumber = Convert.ToInt32(parts[0].Split("-")[1]);//16
                var letter = Convert.ToChar(parts[1].Trim().Remove(parts[1].Trim().Length - 1));//k
                var password = parts[2].Trim().ToCharArray();//kkkkkgmkbvkkrskhd
                if (password[startNumber - 1] == letter && password[endNumber - 1] != letter)
                {
                    Console.WriteLine(line);
                    count++;
                }
                if (password[startNumber - 1] != letter && password[endNumber - 1] == letter)
                {
                    Console.WriteLine(line);
                    count++;
                }
                //if (startNumber <= freq && freq <= endNumber)
                //{
                //    Console.WriteLine(line);
                //    count++;
                //}
            }
            Console.WriteLine($"aantal regels: {lines.Count}, aantal juiste wachtwoorden: {count}.");
            Console.ReadLine();
        }
    }
}
