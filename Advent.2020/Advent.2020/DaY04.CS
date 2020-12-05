using Advent._2020.Helpers;
using Advent._2020.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Advent._2020
{
    public class DaY04
    {
        public void Ex01()
        {
            var countPassport = 0;
            var countValid = 0;
            var countInvalid = 0;
            var lines = FileReaderHelper.GetLines("input04.txt");
            var passportData = string.Empty;
            foreach (var line in lines)
            {
                if (line == string.Empty)
                {
                    var passport = new Passport(passportData.Trim());
                    countPassport++;
                    if (passport.IsValid())
                    {
                        // Console.WriteLine($"valid: {passportData}");
                        countValid++;
                    }
                    else
                    {
                        countInvalid++;
                        //Console.WriteLine($"INvalid: {passportData}");
                    }

                    passportData = string.Empty;
                    continue;
                }
                passportData = passportData + " " + line;
            }
            var lastPassport = new Passport(passportData.Trim());
            countPassport++;
            if (lastPassport.IsValid())
            {
                // Console.WriteLine($"valid: {passportData}");
                countValid++;
            }
            else
            {
                countInvalid++;
                //Console.WriteLine($"INvalid: {passportData}");
            }
            Console.WriteLine($"aantal paspoorten: {countPassport} valide aantal: {countValid} invalide aantal: {countInvalid}");
            Console.ReadLine();
        }
    }
}
