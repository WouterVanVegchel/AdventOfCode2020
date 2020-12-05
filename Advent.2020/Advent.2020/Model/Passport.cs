using System;
using System.Collections.Generic;
using System.Text;

namespace Advent._2020.Model
{
    public class Passport
    {
        public string byr { get; set; }
        public string iyr { get; set; }
        public string eyr { get; set; }
        public string hgt { get; set; }
        public string hcl { get; set; }
        public string ecl { get; set; }
        public string pid { get; set; }
        public string cid { get; set; }
        public string pData { get; set; }

        public Passport(string data)
        {
            pData = data;
            var pairs = data.Split(" ");
            foreach (var pair in pairs)
            {
                var p = pair.Split(":");
                switch (p[0])
                {
                    case ("byr"):
                        byr = p[1];
                        break;
                    case ("iyr"):
                        iyr = p[1];
                        break;
                    case ("eyr"):
                        eyr = p[1];
                        break;
                    case ("hgt"):
                        hgt = p[1];
                        break;
                    case ("hcl"):
                        hcl = p[1];
                        break;
                    case ("ecl"):
                        ecl = p[1];
                        break;
                    case ("pid"):
                        pid = p[1];
                        break;
                    case ("cid"):
                        cid = p[1];
                        break;
                }
            }
        }

        public bool IsValid()
        {
            if (hgt == null || iyr == null || pid == null || ecl == null || eyr == null || hcl == null || byr == null)
            {
                return false;
            }
            //            byr(Birth Year) - four digits; at least 1920 and at most 2002.
            if (Convert.ToInt32(byr)< 1920 || Convert.ToInt32(byr) > 2002)
            {
                return false;
            }
            //iyr(Issue Year) - four digits; at least 2010 and at most 2020.
            if (Convert.ToInt32(iyr) < 2010 || Convert.ToInt32(iyr) > 2020)
            {
                return false;
            }
            //eyr(Expiration Year) - four digits; at least 2020 and at most 2030.
            if (Convert.ToInt32(eyr) < 2020 || Convert.ToInt32(eyr) > 2030)
            {
                return false;
            }
            //hgt(Height) - a number followed by either cm or in:
            //If cm, the number must be at least 150 and at most 193.
            if (hgt.EndsWith("cm"))
            {
                var x = hgt.Replace("cm", "");
                if (Convert.ToInt32(x) < 150 || Convert.ToInt32(x) > 193)
                {
                    return false;
                }
            }
            //If in, the number must be at least 59 and at most 76.\
            if (hgt.EndsWith("in"))
            {
                var x = hgt.Replace("in", "");
                if (Convert.ToInt32(x) < 59 || Convert.ToInt32(x) > 76)
                {
                    return false;
                }
            }
            //hcl(Hair Color) - a # followed by exactly six characters 0-9 or a-f.
            if (!hcl.StartsWith('#'))
            {
                return false;
            }
            else
            {

                var x = hcl.Remove(0, 1);
                if (x.Length != 6)
                {
                    return false;
                }
                var validchars = "0123456789abcdef";
                foreach(char c in x)
                {
                    if (!validchars.Contains(c.ToString()))
                    {
                        return false;
                    }
                }
            }
            //ecl(Eye Color) - exactly one of: amb blu brn gry grn hzl oth.
            var allowedColors = new List<string>
            {
                "amb",
                "blu",
                "brn",
                "gry",
                "grn",
                "hzl",
                "oth"
            };
            if (!allowedColors.Contains(ecl))
            {
                return false;
            }
            //pid(Passport ID) - a nine - digit number, including leading zeroes.
            if(pid.Length != 9)
            {
                return false;
            }
            Console.WriteLine($"data: {pData}");
            return true;
        }
    }
}
