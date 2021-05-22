using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitaminhesaplama
{
    class Portakal : Verim, IDegerler
    {
        private int _agirlik;
        private int _vitamina;
        private int _vitaminc;
        public int Agirlik
        {
            get
            {
                Random rnd = new Random();
                int sayi = rnd.Next(70, 120);
                _agirlik = sayi;
                return _agirlik;
            }

            set
            {


            }
        }
        public int VitaminA
        {
            get => _vitamina = 225;
            set { }
        }
        public int VitaminC
        {
            get => _vitaminc = 45;
            set { }
        }

        internal IDegerler IDegerler
        {
            get => default;
            set
            {
            }
        }

        internal IDegerler IDegerler1
        {
            get => default;
            set
            {
            }
        }

        public float Vithesaplama(int yeniagirlik, int vitamin)
        {
            float sonuc = vitamin * yeniagirlik / 100;

            return sonuc;
        }
    }
}
