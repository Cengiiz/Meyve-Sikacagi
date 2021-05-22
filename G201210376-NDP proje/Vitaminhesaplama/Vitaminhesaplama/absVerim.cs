using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitaminhesaplama
{
    abstract class Verim
    {
        public Form1 Form1
        {
            get => default;
            set
            {
            }
        }

        public int KatiVerim()
        {
                Random rnd = new Random();
                int verim = rnd.Next(80,95);
                return verim;
        }
        public int SiviVerim()
        {
            Random rnd = new Random();
            int verim = rnd.Next(30, 70);
            return verim;
        }
        

    }
}
