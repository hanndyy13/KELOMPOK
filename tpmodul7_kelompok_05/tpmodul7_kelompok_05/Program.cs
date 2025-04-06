using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
public class DataMahasiswa103022300064
{
    public class Nama
    {
        public string belakang { get; set; }
        public string depan { get; set; }
    }
    public class Mahasiswa
    {
        public Nama nama { get; set; }
        public long nim { get; set; }
        public string fakultas { get; set; }
    }

    public static void readJSON()
    {
        string jsonString = File.ReadAllText("D:\\My Code\\GUI C#\\KELOMPOK\\tpmodul7_kelompok_05\\tpmodul7_kelompok_05\\tp7_1_103022300064.json");
        Mahasiswa? mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(jsonString);
        if (mahasiswa != null)
        {
            Console.WriteLine($"Nama {mahasiswa.nama.depan} {mahasiswa.nama.belakang} dengan nim {mahasiswa.nim} dari fakultas {mahasiswa.fakultas}");
        }
        else
        {
            Console.WriteLine("Failed to deserialize JSON.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa103022300064.readJSON();
    }
}
