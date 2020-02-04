using csv.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace csv
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\saba0\Desktop\Big data\1st Sem\Information encoding standard\info.csv";
            string fileContents;
            using (StreamReader stream = new StreamReader(filePath))
            {
                fileContents = stream.ReadToEnd();
            }
            List<string> entries = new List<string>();
            entries = fileContents.Split("\r\n", StringSplitOptions.RemoveEmptyEntries).ToList();
            // string[] data = entries[1].Split(",", StringSplitOptions.None);
            Student student = new Student();
            student.FromCSV(entries[1]);

            // Student student = new Student
            // {
            //   StudentId = data[0],
            // FirstName = data[1],
            //LastName = data[2],
            //DateOfBirth = data[3],
            //ImageData = data[4]
            //};

            Console.WriteLine(student.ToCSV());
            Console.WriteLine(student.ToString());
            Console.WriteLine(fileContents);
        
            
        }
    }
}
