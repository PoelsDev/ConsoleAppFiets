using System;

namespace ConsoleAppFiets
{
    class Fiets
    {
        private string kleur;
        public bool HeeftFietsbel { get; set; } = true;

        public string Info()
        {
            return $"Deze fiets is {kleur} en heeft {(HeeftFietsbel ? "een" : "geen")} fietsbel";
        }

        public Fiets(string kleur)
        {
            this.kleur = kleur;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fiets joskesFiets = new Fiets("groen");
            Fiets miekesFiets = new Fiets("blauw");

            joskesFiets.HeeftFietsbel = true;
            miekesFiets.HeeftFietsbel = false;

            Console.WriteLine($"Info over Joske's fiets: {joskesFiets.Info()}");
            Console.WriteLine($"Info over Mieke's fiets: {miekesFiets.Info()}");
        }
    }

}
