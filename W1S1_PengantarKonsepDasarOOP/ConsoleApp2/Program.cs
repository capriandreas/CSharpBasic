using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Segitiga LuasSegigita = new Segitiga(4,5);
            Console.WriteLine("Luas segitiga = " + LuasSegigita.HitLuas());

            BujurSangkar LuasBujurSangkar = new BujurSangkar(2);
            Console.WriteLine("Luas bujur sangkar = " + LuasBujurSangkar.HitLuas());

            Console.ReadKey();
        }
    }

    public abstract class HitungLuas
    {
        protected double luas;
        public abstract double HitLuas();
    }

    public class Segitiga : HitungLuas
    {
        private double alas, tinggi;

        public Segitiga(double a, double t)
        {
            alas = a;
            tinggi = t;
        }

        public override double HitLuas()
        {
            luas = 0.5 * alas * tinggi;
            return luas;
        }
    }

    public class BujurSangkar : HitungLuas
    {
        private double sisi;

        public BujurSangkar(double s)
        {
            sisi = s;
        }

        public override double HitLuas()
        {
            luas = sisi * sisi;
            return sisi;
        }
    }
}
