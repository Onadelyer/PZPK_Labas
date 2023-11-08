using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
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

        public static void WriteToBinaryFile<T>(string filePath, T objectToWrite)
        {
            // Disable the SYSLIB0011 warning temporarily
            #pragma warning disable SYSLIB0011
            // Serialize and write the object to a binary file
            BinaryFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, objectToWrite);
            }
            #pragma warning restore SYSLIB0011
        }

        public static T ReadFromBinaryFile<T>(string filePath)
        {
            if (!File.Exists(filePath))
            {
                // Create the file if it does not exist
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    // You can write to the file here if needed
                }
            }
            // Disable the SYSLIB0011 warning temporarily
#pragma warning disable SYSLIB0011
            // Read the object back from the binary file
            BinaryFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                try
                {
                    T readObject = (T)formatter.Deserialize(stream);
                    return readObject;
                }
                catch
                {
                    return default(T);
                }
            }
            #pragma warning restore SYSLIB0011
        }
    }
}
