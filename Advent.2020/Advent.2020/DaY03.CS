using Advent._2020.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Advent._2020
{
    public class DaY03
    {
        public void Ex01()
        {
            int count = 0;
            var lines = FileReaderHelper.GetLines("input03.txt");
            var index = 1;
            foreach (var line in lines)
            {
                var currentLine = line;
                var l = currentLine.Length;
                var position = (index * 3) - 2;
                while (currentLine.Length <= position)
                {
                    currentLine = currentLine + line;
                }
                if (currentLine.ToCharArray()[position -1] == '#')
                {
                    count++;
                }
                index++;
            }
            Console.WriteLine($" rechts 3 down 1 geeft aantal: {count}");
            Console.ReadLine();
            long drie = count;

            count = 0;
            lines = FileReaderHelper.GetLines("input03.txt");
            index = 1;
            foreach (var line in lines)
            {
                var currentLine = line;
                var l = currentLine.Length;
                var position = index;
                while (currentLine.Length <= position)
                {
                    currentLine = currentLine + line;
                }
                if (currentLine.ToCharArray()[position - 1] == '#')
                {
                    // Console.WriteLine($"line: {currentLine} ppositie: {position}");
                    count++;
                }
                index++;
            }
            Console.WriteLine($" rechts 1 down 1 geeft aantal: {count}");
            Console.ReadLine();

            long een = count;

            count = 0;
            lines = FileReaderHelper.GetLines("input03.txt");
            index = 1;
            foreach (var line in lines)
            {
                var currentLine = line;
                var l = currentLine.Length;
                var position = (index * 5) - 4;
                while (currentLine.Length <= position)
                {
                    currentLine = currentLine + line;
                }
                if (currentLine.ToCharArray()[position - 1] == '#')
                {
                    // Console.WriteLine($"line: {currentLine} ppositie: {position}");
                    count++;
                }
                index++;
            }
            Console.WriteLine($" rechts 5 down 1 geeft aantal: {count}");
            Console.ReadLine();
            long vijf = count;

            count = 0;
            lines = FileReaderHelper.GetLines("input03.txt");
            index = 1;
            foreach (var line in lines)
            {
                var currentLine = line;
                var l = currentLine.Length;
                var position = (index * 7) - 6;
                while (currentLine.Length <= position)
                {
                    currentLine = currentLine + line;
                }
                if (currentLine.ToCharArray()[position - 1] == '#')
                {
                    // Console.WriteLine($"line: {currentLine} ppositie: {position}");
                    count++;
                }
                index++;
            }
            Console.WriteLine($" rechts 7 down 1 geeft aantal: {count}");
            Console.ReadLine();
            long zeven = count;

            count = 0;
            lines = FileReaderHelper.GetLines("input03.txt");
            index = 1;
            foreach (var line in lines)
            {
                if( index%2 == 0)
                {
                    index++;
                    continue;
                }
                var currentLine = line;
                var l = currentLine.Length;
                var position = (index + 1)/2;
                while (currentLine.Length <= position)
                {
                    currentLine = currentLine + line;
                }
                if (currentLine.ToCharArray()[position - 1] == '#')
                {
                    // Console.WriteLine($"line: {currentLine} ppositie: {position}");
                    count++;
                }
                index++;
            }
            Console.WriteLine($" rechts 1 down 2 geeft aantal: {count}");
            Console.ReadLine();
            long twee = count;
            Console.WriteLine($"totaal: {een * twee * drie * vijf * zeven}");
        }
    }
}
