using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Laba5
{
    public class FileHandler
    {
        public static string[] ReadFromTextFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                // Create the file if it does not exist
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    // You can write to the file here if needed
                }
            }

            // Read from the file
            string[] lines = File.ReadAllLines(filePath);
            return lines;
        }

        public static void WriteToTextFile(string filePath, string[] lines)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (var line in lines)
                {
                    sw.WriteLine(line);
                }
            }
        }
    }
}
