using System.Collections.Generic;
using System.IO;

namespace Advent._2020.Helpers
{
    public static class FileReaderHelper
    {
        public static List<string> GetLines(string fileName)
        {
            List<string> lines = new List<string>();
            string line;

            StreamReader file = new StreamReader($"C:\\input\\{fileName}");
            while ((line = file.ReadLine()) != null)
            {
                lines.Add(line);
            }

            file.Close();
            return lines;
        }
    }
}
