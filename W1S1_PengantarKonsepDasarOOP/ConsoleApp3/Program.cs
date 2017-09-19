using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Kodok kodokBergerak = new Kodok("Melompat");
            Console.WriteLine("Kodok bergerak dengan cara = " + kodokBergerak.bergerak());

            Ular ularBergerak = new Ular("Merayap");
            Console.WriteLine("Ular bergerak dengan cara = " + ularBergerak.bergerak());

            Console.ReadKey();
        }
    }

    public abstract class HewanBergerak
    {
        protected string gerak;

        public abstract string bergerak();
        
    }

    public class Kodok : HewanBergerak
    {
        private string kodokgerak;

        public Kodok(String g)
        {
            kodokgerak = g;
        }

        public override string bergerak()
        {
            gerak = kodokgerak;
            return kodokgerak;
        }
    }

    public class Ular : HewanBergerak
    {
        private string ulargerak;

        public Ular(String g)
        {
            ulargerak = g;
        }

        public override string bergerak()
        {
            gerak = ulargerak;
            return ulargerak;
        }
    }
}
