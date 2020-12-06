using System;
using System.Collections.Generic;
using System.Text;

namespace Advent._2020.Model
{
    public class Group
    {
        public int NumberOfPeope { get; set; }

        public Dictionary<string, int> GivenAnswers { get; set; }

        public List<GroupMember> Members { get; set; }
        public Group()
        {
            Members = new List<GroupMember>();
        }
    }
}
