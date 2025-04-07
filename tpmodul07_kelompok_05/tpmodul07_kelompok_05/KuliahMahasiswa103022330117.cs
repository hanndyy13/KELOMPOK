using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul07_kelompok_05
{
    public class MataKuliah
    {
        [JsonPropertyName("code")]
        public string Kode { get; set; }

        [JsonPropertyName("name")]
        public string Nama { get; set; }
    }

    public class DaftarMataKuliah
    {
        [JsonPropertyName("courses")]
        public List<MataKuliah> Courses { get; set; }
    }

    public class KuliahMahasiswa103022330117
    {
        public static void ReadJSON()
        {
            string filePath = "tp7_2_103022330117.json";

            try
            {
                string jsonString = File.ReadAllText(filePath);
                DaftarMataKuliah daftar = JsonSerializer.Deserialize<DaftarMataKuliah>(jsonString);

                Console.WriteLine("Daftar mata kuliah yang diambil:");
                int i = 1;
                foreach (var mk in daftar.Courses)
                {
                    Console.WriteLine($"MK {i} {mk.Kode} - {mk.Nama}");
                    i++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Terjadi error: {ex.Message}");
            }
        }
    }
}