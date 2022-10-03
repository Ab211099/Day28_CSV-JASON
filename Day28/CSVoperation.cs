using CsvHelper;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Day28
{
    public class CSVoperation
    {
        public static void CsvSerialize()
        {
            Console.WriteLine("WelCome");
            Student s = new Student();

            string csvFilePath = @"C:\Users\Administrator\Desktop\Day28_CSV-JASON\Day28\Data.csv";

            List<Student> students = new List<Student>()
            {
                new Student(){FName="Abhi",LName="Bhave",Address="Pune",ZipCode=411028},
                new Student(){FName="Rahul",LName="walanj",Address="Pune",ZipCode=411028}
            };

            StreamWriter sw = new StreamWriter(csvFilePath);
            CsvWriter cw = new CsvWriter(sw, CultureInfo.InvariantCulture);

            cw.WriteRecords<Student>(students);
            sw.Close();
            Console.WriteLine("Closed");
        }

        public static void CsvDeserialize()
        {
            string csvFilePath = @"C:\Users\Administrator\Desktop\Day28_CSV-JASON\Day28\Data.csv";
            StreamReader swReader = new StreamReader(csvFilePath);

            CsvReader csvReader = new CsvReader(swReader, CultureInfo.InvariantCulture);

            List<Student> students1 = csvReader.GetRecords<Student>().ToList();

            foreach (Student student in students1)
            {
                Console.WriteLine(student);
            }
            

           
        }
    }
}
