using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitaminhesaplama
{
    class Sikacak
    {
        public Form1 Form1
        {
            get => default;
            set
            {
            }
        }

        public int sikacak(int agirlik,int kativerim )
        {
            
            int c = agirlik;
            int d = kativerim;
            

            return c*d/100;
        }
    }
}
