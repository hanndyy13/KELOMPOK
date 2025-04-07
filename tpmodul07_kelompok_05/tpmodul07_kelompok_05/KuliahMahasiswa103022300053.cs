using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace tpmodul07_kelompok_05
{
    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class CourseList
    {
        public List<Course> courses { get; set; }
    }

    public class KuliahMahasiswa103022300053
    {
        public static void ReadJSON()
        {
            string filePath = "tp7_2_103022300053.json";

            try
            {
                string jsonContent = File.ReadAllText(filePath);
                CourseList list = JsonSerializer.Deserialize<CourseList>(jsonContent);

                Console.WriteLine("Daftar mata kuliah yang diambil:");
                int index = 1;
                foreach (var course in list.courses)
                {
                    Console.WriteLine($"MK {index} {course.code} - {course.name}");
                    index++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Terjadi kesalahan saat membaca file JSON: {ex.Message}");
            }
        }
    }
}
