using Advent._2020.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Advent._2020
{
    public class Day05
    {
        public void Ex01()
        {
            var lines = FileReaderHelper.GetLines("input05.txt");
            var highestSeatId = 0;
            List<int> seatList = new List<int>();
            foreach (var line in lines)
            {
                var row = line.Remove(7).ToCharArray().ToList();
                var seat = line.Remove(0, 7).ToCharArray().ToList();
                int start = 0;
                int end = 127;
                var rowNumber = GetRowNumber(start, end, row);
                var seatStart = 0;
                var seatEnd = 7;
                var seatNumber = GetSeatNumber(seatStart, seatEnd, seat);
                var result = (rowNumber * 8) + seatNumber;
                if (result > highestSeatId)
                {
                    highestSeatId = result;
                }
                seatList.Add(result);


            }
            var orderedList = seatList.OrderBy(x => x);
            var missinglist = new List<int>();
            foreach (var item in orderedList)
            {
                if (!seatList.Contains(item + 1))
                {
                    missinglist.Add(item + 1);
                }
            }
            Console.WriteLine($"hoogste: {highestSeatId}");
            Console.ReadLine();
        }

        private int GetSeatNumber(int seatStart, int seatEnd, List<char> seat)
        {
            int currentStart = seatStart;
            int currentEnd = seatEnd;
            var currentRow = seat;
            if (currentRow.First() == 'L')
            {
                currentEnd = ((currentStart + currentEnd + 1) / 2) - 1;
            }
            else
            {
                currentStart = (currentStart + currentEnd + 1) / 2;
            }
            currentRow.RemoveAt(0);
            if (currentRow.First() == 'L')
            {
                currentEnd = ((currentStart + currentEnd + 1) / 2) - 1;
            }
            else
            {
                currentStart = (currentStart + currentEnd + 1) / 2;
            }
            currentRow.RemoveAt(0);
            if (currentRow.First() == 'L')
            {
                currentEnd = ((currentStart + currentEnd + 1) / 2) - 1;
            }
            else
            {
                currentStart = (currentStart + currentEnd + 1) / 2;
            }
            return currentStart;
        }

        private int GetRowNumber(int start, int end, List<char> row)
        {
            int currentStart = start;
            int currentEnd = end;
            var currentRow = row;
            if (currentRow.First() == 'F')
            {
                currentEnd = ((currentStart + currentEnd + 1) / 2) - 1;
            }
            else
            {
                currentStart = (currentStart + currentEnd + 1) / 2;
            }
            currentRow.RemoveAt(0);
            if (currentRow.First() == 'F')
            {
                currentEnd = ((currentStart + currentEnd + 1) / 2) - 1;
            }
            else
            {
                currentStart = (currentStart + currentEnd + 1) / 2;
            }
            currentRow.RemoveAt(0);
            if (currentRow.First() == 'F')
            {
                currentEnd = ((currentStart + currentEnd + 1) / 2) - 1;
            }
            else
            {
                currentStart = (currentStart + currentEnd + 1) / 2;
            }
            currentRow.RemoveAt(0);
            if (currentRow.First() == 'F')
            {
                currentEnd = ((currentStart + currentEnd + 1) / 2) - 1;
            }
            else
            {
                currentStart = (currentStart + currentEnd + 1) / 2;
            }
            currentRow.RemoveAt(0);
            if (currentRow.First() == 'F')
            {
                currentEnd = ((currentStart + currentEnd + 1) / 2) - 1;
            }
            else
            {
                currentStart = (currentStart + currentEnd + 1) / 2;
            }
            currentRow.RemoveAt(0);
            if (currentRow.First() == 'F')
            {
                currentEnd = ((currentStart + currentEnd + 1) / 2) - 1;
            }
            else
            {
                currentStart = (currentStart + currentEnd + 1) / 2;
            }
            currentRow.RemoveAt(0);
            if (currentRow.First() == 'F')
            {
                currentEnd = ((currentStart + currentEnd + 1) / 2) - 1;
            }
            else
            {
                currentStart = (currentStart + currentEnd + 1) / 2;
            }
            return currentStart;
        }
    }
}
