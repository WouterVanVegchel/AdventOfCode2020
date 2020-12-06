using Advent._2020.Helpers;
using Advent._2020.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent._2020
{
    public class Day06
    {
        public void Ex1()
        {
            var lines = FileReaderHelper.GetLines("input06.txt");
            var groupCount = new Dictionary<int, int>();
            var currentGroupAnswers = string.Empty;
            int index = 0;
            foreach (var line in lines)
            {
                if (line == string.Empty)
                {
                    var answers = currentGroupAnswers.ToCharArray().Distinct().Count();
                    groupCount.Add(index, answers);
                    currentGroupAnswers = string.Empty;
                    index++;
                }
                currentGroupAnswers += line;
            }
            var last = currentGroupAnswers.ToCharArray().Distinct().Count();
            groupCount.Add(index, last);
            var sum = 0;
            foreach (var item in groupCount.Values)
            {
                sum += item;
            }
            Console.WriteLine($"aantal: {sum}");
            Console.ReadLine();
        }
        public void Ex2()
        {
            var lines = FileReaderHelper.GetLines("input06.txt");
            var groupCount = new List<int>();
            Group group = new Group();
            foreach (var line in lines)
            {
                if (line == string.Empty)
                {
                    groupCount.Add(GetIntersectingAnswers(group));
                    group = new Group();

                }
                else
                {
                    group.Members.Add(new GroupMember(line));
                }

            }
            groupCount.Add(GetIntersectingAnswers(group));
            var sum = 0;
            foreach (var item in groupCount)
            {
                sum += item;
            }
            Console.WriteLine($"aantal: {sum}");
            Console.ReadLine();
        }

        private int GetIntersectingAnswers(Group group)
        {
            var intersectingAnswers = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            foreach (var member in group.Members)
            {
                intersectingAnswers = intersectingAnswers.Intersect(member.GivenAnswers).ToArray();
            }
            return intersectingAnswers.Count();
        }
    }
}
