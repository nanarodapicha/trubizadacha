using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trubi.Model;

namespace trubi.View
{
    public class Display
    {
        public int Obem { get; set; }
        public int P1 { get; set; }
        public int P2 { get; set; }
        public double H { get; set; }
        public void Input()
        {
            Console.Write("Vuvedi obem: ");
            int oobem= int.Parse(Console.ReadLine());
            this.Obem=oobem;

            Console.Write("Vuvedi debit na purvata truba: ");
            int pp1= int.Parse(Console.ReadLine());
            this.P1 = pp1;

            Console.Write("Vuvedi debit na vtorata truba: ");
            int pp2 = int.Parse(Console.ReadLine());
            this.P2 = pp2;


            Console.Write("Vuvedi chasove na koito rabotnika otsutva: ");
            double hh = double.Parse(Console.ReadLine());
            this.H = hh;

        }
       
        public void Output()
        {
            double obshtoT = (P1 * H) + (P2 * H);
            if (obshtoT <= Obem)
            {
                double baseinpro = (obshtoT / Obem) * 100;
                double pipe1Percentage = (P1 * H) / obshtoT * 100;
                double pipe2Percentage = (P2 * H) / obshtoT * 100;

                Console.WriteLine($"Baseina e na {Math.Floor(baseinpro)}% pulen \ntruba 1: {Math.Floor(pipe1Percentage)}%\ntruba 2: {Math.Floor(pipe2Percentage)}%");
            }
            else
            {
                double preliva = obshtoT - Obem;            
                Console.WriteLine($"Za {H} chasa baseina preliva s {preliva} litra");
            }
        }
    }
}
