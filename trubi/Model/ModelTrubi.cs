using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trubi.Model
{
    public class ModelTrubi
    {
        private int obem; 
        private int p1;    
        private int p2;    
        private double h;
       
        public double H
        {
            get { return this.h; }
            set
            {
                if (value >= 1.0 && value <= 24.0)
                {
                    this.h = value;
                }
                else
                {
                    Console.WriteLine("Chasovete trqbva da sa mejdu 1.0 i 24.0");
                }
            }
        }

        public int Obem
        {
            get { return this.obem; }
            set
            {
                if (value >= 1 && value <= 10000)
                {
                    this.obem = value;
                }
                else
                {
                    Console.WriteLine("Obemut trqbva da e mejdu 1 i 10 000");
                }
            }
        }

        public int P1
        {
            get { return this.p1; }
            set
            {
                if (value >= 1 && value <= 5000)
                {
                    this.p1 = value;
                }
                else
                {
                    Console.WriteLine("Debitut na purvata truba trqbva da e mejdu 1 i 5000");
                }
            }
        }

        public int P2
        {
            get { return this.p2; }
            set
            {
                if (value >= 1 && value <= 5000)
                {
                    this.p2 = value;
                }
                else
                {
                    Console.WriteLine("Debitut na vtorata truba trqbva da e mejdu 1 i 5000");
                }
            }
        }
        public ModelTrubi()
        {
                
        }
        public double ObshtoTrubi()
        {
            return (P1 * H) + (P2 * H);
        }

    }
}
