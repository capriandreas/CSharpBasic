using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa capri = new Mahasiswa();
            capri.NamaMahasiswa = "Andreas";
            capri.NimMahasiswa = "11314048";

            Console.WriteLine(capri.NamaMahasiswa);
            Console.WriteLine(capri.NimMahasiswa);
            Console.ReadKey();
        }
    }

    public class Mahasiswa
    {
        String nim;
        String nama;

        public String NamaMahasiswa
        {
            get { return nama; }
            set { nama = value; }
        }

        public String NimMahasiswa
        {
            get { return nim; }
            set { nim = value; }
        }
    }
}
