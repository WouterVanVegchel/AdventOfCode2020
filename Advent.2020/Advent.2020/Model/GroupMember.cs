using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Advent._2020.Model
{
    public class GroupMember
    {
        public List<char> GivenAnswers { get; set; }

        public GroupMember(string answers)
        {
            GivenAnswers = answers.ToCharArray().ToList();
        }
    }
}
