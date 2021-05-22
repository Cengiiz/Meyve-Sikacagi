using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vitaminhesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Ksikacak.Enabled = false;
            Ssikacak.Enabled = false;
            using (System.IO.StreamWriter dosya = new System.IO.StreamWriter("Hesaplamalar.txt"))
            {

            }
        }
        int saniye = 60;
        string[] resimler = Directory.GetFiles(@"resimler", "*.jpg");
        int agirlik;
        float vitaminA;
        float vitaminC;
        int verim;
        Sikacak Sikacak = new Sikacak();
        int yeniAgirlik;
        int toplamA = 0;
        int toplamC = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
           
            saniye = saniye - 1;
            zaman.Text = saniye.ToString();
            if (saniye > 0)
            {
                btnBasla.Enabled = false;
                
            }
            else
            {
                btnBasla.Enabled = true;
                Ksikacak.Enabled = false;
                Ssikacak.Enabled = false;
                timer1.Stop();
                zaman.Text = "60";
            }
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            saniye = 60;
            timer1.Start();
            Random rnd = new Random();
           resim.ImageLocation = resimler[rnd.Next(0, resimler.Length)];
            Ksikacak.Enabled = true;
            Ssikacak.Enabled = true;
        }

        private void Ksikacak_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (resim.ImageLocation == resimler[0])//armut
            {
                anlikislem.Clear();
                resim.ImageLocation = resimler[rnd.Next(0, resimler.Length)]; 
                Armut armut = new Armut();
                agirlik = armut.Agirlik;
                verim = armut.KatiVerim();
                yeniAgirlik = Sikacak.sikacak(agirlik, verim);
                vitaminA = armut.Vithesaplama(yeniAgirlik, armut.VitaminA);
                vitaminC = armut.Vithesaplama(yeniAgirlik, armut.VitaminC);
                anlikislem.Text = "-Armutun hesaplamalari-" + Environment.NewLine + "Agirlik:" + agirlik.ToString() + Environment.NewLine + "Verim:" + verim.ToString() + Environment.NewLine + "Yeni Agirlik:" + yeniAgirlik.ToString() + Environment.NewLine + "Armutta ki 100 gr A vitamin degeri=" + armut.VitaminA.ToString()+ Environment.NewLine + "Armutta ki 100 gr C vitamin degeri=" +armut.VitaminC.ToString()+ Environment.NewLine + "VitaminA=" + vitaminA.ToString() + " iu" + "   VitaminC=" + vitaminC.ToString() + " mg";
                using (System.IO.StreamWriter dosya = new System.IO.StreamWriter("Hesaplamalar.txt", true))
                {
                    dosya.WriteLine("--Armutun hesaplamalari--");
                    dosya.WriteLine("Agirlik:" + agirlik);
                    dosya.WriteLine("Verim:" + verim);
                    dosya.WriteLine("Yeni Agirlik:" + yeniAgirlik);
                    dosya.WriteLine("Armutta ki 100 gr A vitamin degeri=" + armut.VitaminA);
                    dosya.WriteLine("Armutta ki 100 gr C vitamin degeri=" + armut.VitaminC);
                    dosya.WriteLine("VitaminA=" + vitaminA + " iu");
                    dosya.WriteLine("VitaminC=" + vitaminC + " mg");
                }
                textdosyasi.Text = File.ReadAllText(@"Hesaplamalar.txt");
                toplamA = toplamA + armut.VitaminA;
                toplamC = toplamC + armut.VitaminC;
                vitA.Text = toplamA.ToString();
                vitC.Text = toplamC.ToString();

   
            }
            if (resim.ImageLocation == resimler[1] )//cilek
            {
                anlikislem.Clear();
                resim.ImageLocation = resimler[rnd.Next(0, resimler.Length)];
                Armut cilek = new Armut();
                agirlik = cilek.Agirlik;
                verim = cilek.KatiVerim();
                yeniAgirlik = Sikacak.sikacak(agirlik, verim);
                vitaminA = cilek.Vithesaplama(yeniAgirlik, cilek.VitaminA);
                vitaminC = cilek.Vithesaplama(yeniAgirlik, cilek.VitaminC);
                anlikislem.Text = "-Cilegin hesaplamalari-" + Environment.NewLine + "Agirlik:" + agirlik.ToString() + Environment.NewLine + "Verim:" + verim.ToString() + Environment.NewLine + "Yeni Agirlik:" + yeniAgirlik.ToString() + Environment.NewLine + "Cilekte ki 100 gr A vitamin degeri=" + cilek.VitaminA.ToString() + Environment.NewLine + "Cilekte ki 100 gr C vitamin degeri=" + cilek.VitaminC.ToString() + Environment.NewLine + "VitaminA=" + vitaminA.ToString() + " iu" + "   VitaminC=" + vitaminC.ToString() + " mg";
                using (System.IO.StreamWriter dosya = new System.IO.StreamWriter("Hesaplamalar.txt", true))
                {
                    dosya.WriteLine("--Cilegin hesaplamalari--");
                    dosya.WriteLine("Agirlik:" + agirlik);
                    dosya.WriteLine("Verim:" + verim);
                    dosya.WriteLine("Yeni Agirlik:" + yeniAgirlik);
                    dosya.WriteLine("Armutta ki 100 gr A vitamin degeri=" + cilek.VitaminA);
                    dosya.WriteLine("Armutta ki 100 gr C vitamin degeri=" + cilek.VitaminC);
                    dosya.WriteLine("VitaminA=" + vitaminA + " iu");
                    dosya.WriteLine("VitaminC=" + vitaminC + " mg");
                }
                textdosyasi.Text = File.ReadAllText(@"Hesaplamalar.txt");
                toplamA = toplamA + cilek.VitaminA;
                toplamC = toplamC + cilek.VitaminC;
                vitA.Text = toplamA.ToString();
                vitC.Text = toplamC.ToString();
            }
            if (resim.ImageLocation == resimler[2])//elma
            {
                anlikislem.Clear();
                resim.ImageLocation = resimler[rnd.Next(0, resimler.Length)]; 
                Elma elma = new Elma();
                agirlik = elma.Agirlik;
                verim = elma.KatiVerim();
                yeniAgirlik = Sikacak.sikacak(agirlik,verim);
                vitaminA = elma.Vithesaplama(yeniAgirlik, elma.VitaminA);
                vitaminC = elma.Vithesaplama(yeniAgirlik, elma.VitaminC);
                anlikislem.Text = "-Elmanin hesaplamalari-" + Environment.NewLine + "Agirlik:" + agirlik.ToString() + Environment.NewLine + "Verim:" + verim.ToString() + Environment.NewLine + "Yeni Agirlik:" + yeniAgirlik.ToString() + Environment.NewLine + "Elmada ki 100 gr A vitamin degeri=" + elma.VitaminA.ToString() + Environment.NewLine + "Elmda ki 100 gr C vitamin degeri=" + elma.VitaminC.ToString() + Environment.NewLine + "VitaminA=" + vitaminA.ToString() + " iu" + "   VitaminC=" + vitaminC.ToString() + " mg";
                using (System.IO.StreamWriter dosya = new System.IO.StreamWriter("Hesaplamalar.txt", true))
                {
                    dosya.WriteLine("--Elmanin hesaplamalari--");
                    dosya.WriteLine("Agirlik:" + agirlik);
                    dosya.WriteLine("Verim:" + verim);
                    dosya.WriteLine("Yeni Agirlik:" + yeniAgirlik);
                    dosya.WriteLine("Armutta ki 100 gr A vitamin degeri=" + elma.VitaminA);
                    dosya.WriteLine("Armutta ki 100 gr C vitamin degeri=" + elma.VitaminC);
                    dosya.WriteLine("VitaminA=" + vitaminA + " iu");
                    dosya.WriteLine("VitaminC=" + vitaminC + " mg");
                }
                textdosyasi.Text = File.ReadAllText(@"Hesaplamalar.txt");
                toplamA = toplamA + elma.VitaminA;
                toplamC = toplamC + elma.VitaminC;
                vitA.Text = toplamA.ToString();
                vitC.Text = toplamC.ToString();

            }

        }

        private void Ssikacak_Click(object sender, EventArgs e)
        {
            
            Random rnd = new Random();

            if (resim.ImageLocation == resimler[3])//greyfurt
            {
                anlikislem.Clear();
                resim.ImageLocation = resimler[rnd.Next(0, resimler.Length)];
                Greyfurt greyfurt = new Greyfurt();
                agirlik = greyfurt.Agirlik;
                verim = greyfurt.SiviVerim();
                yeniAgirlik = Sikacak.sikacak(agirlik, verim);
                vitaminA = greyfurt.Vithesaplama(yeniAgirlik, greyfurt.VitaminA);
                vitaminC = greyfurt.Vithesaplama(yeniAgirlik, greyfurt.VitaminC);
                anlikislem.Text = "-Greyfurt hesaplamalari-" + Environment.NewLine + "Agirlik:" + agirlik.ToString() + Environment.NewLine + "Verim:" + verim.ToString() + Environment.NewLine + "Yeni Agirlik:" + yeniAgirlik.ToString() + Environment.NewLine + "Greyfurtta ki 100 gr A vitamin degeri=" + greyfurt.VitaminA.ToString() + Environment.NewLine + "Greyfurtta ki 100 gr C vitamin degeri=" + greyfurt.VitaminC.ToString() + Environment.NewLine + "VitaminA=" + vitaminA.ToString() + " iu" + "   VitaminC=" + vitaminC.ToString() + " mg";
                
                using (System.IO.StreamWriter dosya = new System.IO.StreamWriter("Hesaplamalar.txt", true))
                {
                    dosya.WriteLine("--Greyfurt hesaplamalari--");
                    dosya.WriteLine("Agirlik:" + agirlik);
                    dosya.WriteLine("Verim:" + verim);
                    dosya.WriteLine("Yeni Agirlik:" + yeniAgirlik);
                    dosya.WriteLine("Armutta ki 100 gr A vitamin degeri=" + greyfurt.VitaminA);
                    dosya.WriteLine("Armutta ki 100 gr C vitamin degeri=" + greyfurt.VitaminC);
                    dosya.WriteLine("VitaminA=" + vitaminA + " iu");
                    dosya.WriteLine("VitaminC=" + vitaminC + " mg");
                }
                textdosyasi.Text = File.ReadAllText(@"Hesaplamalar.txt");
                toplamA = toplamA + greyfurt.VitaminA;
                toplamC = toplamC + greyfurt.VitaminC;
                vitA.Text = toplamA.ToString();
                vitC.Text = toplamC.ToString();

            }
            if (resim.ImageLocation == resimler[4])//mandalina
            {
                anlikislem.Clear();
                resim.ImageLocation = resimler[rnd.Next(0, resimler.Length)];
                Mandalina mandalina = new Mandalina();
                agirlik = mandalina.Agirlik;
                verim = mandalina.SiviVerim();
                yeniAgirlik = Sikacak.sikacak(agirlik, verim);
                vitaminA = mandalina.Vithesaplama(yeniAgirlik, mandalina.VitaminA);
                vitaminC = mandalina.Vithesaplama(yeniAgirlik, mandalina.VitaminC);
                anlikislem.Text = "-Mandalina hesaplamalari-" + Environment.NewLine + "Agirlik:" + agirlik.ToString() + Environment.NewLine + "Verim:" + verim.ToString() + Environment.NewLine + "Yeni Agirlik:" + yeniAgirlik.ToString() + Environment.NewLine + "Mandalinada ki 100 gr A vitamin degeri=" + mandalina.VitaminA.ToString() + Environment.NewLine + "Mandalinada ki 100 gr C vitamin degeri=" + mandalina.VitaminC.ToString() + Environment.NewLine + "VitaminA=" + vitaminA.ToString() + " iu" + "   VitaminC=" + vitaminC.ToString() + " mg";
                using (System.IO.StreamWriter dosya = new System.IO.StreamWriter("Hesaplamalar.txt", true))
                {
                    dosya.WriteLine("--Mandlina hesaplamalari--");
                    dosya.WriteLine("Agirlik:" + agirlik);
                    dosya.WriteLine("Verim:" + verim);
                    dosya.WriteLine("Yeni Agirlik:" + yeniAgirlik);
                    dosya.WriteLine("Mandalinadaki ki 100 gr A vitamin degeri=" + mandalina.VitaminA);
                    dosya.WriteLine("Mandalinadaki 100 gr C vitamin degeri=" + mandalina.VitaminC);
                    dosya.WriteLine("VitaminA=" + vitaminA + " iu");
                    dosya.WriteLine("VitaminC=" + vitaminC + " mg");
                }
                textdosyasi.Text = File.ReadAllText(@"Hesaplamalar.txt");
                toplamA = toplamA + mandalina.VitaminA;
                toplamC = toplamC + mandalina.VitaminC;
                vitA.Text = toplamA.ToString();
                vitC.Text = toplamC.ToString();
            }
            if (resim.ImageLocation == resimler[5])//portakal
            {
                anlikislem.Clear();
                resim.ImageLocation = resimler[rnd.Next(0, resimler.Length)];
                Portakal portakal = new Portakal();
                agirlik = portakal.Agirlik;
                verim = portakal.SiviVerim();
                yeniAgirlik = Sikacak.sikacak(agirlik, verim);
                vitaminA = portakal.Vithesaplama(yeniAgirlik, portakal.VitaminA);
                vitaminC = portakal.Vithesaplama(yeniAgirlik, portakal.VitaminC);
                anlikislem.Text = "-Portakal hesaplamalari-" + Environment.NewLine + "Agirlik:" + agirlik.ToString() + Environment.NewLine + "Verim:" + verim.ToString() + Environment.NewLine + "Yeni Agirlik:" + yeniAgirlik.ToString() + Environment.NewLine + "Portakalda ki 100 gr A vitamin degeri=" + portakal.VitaminA.ToString() + Environment.NewLine + "Portakalda ki 100 gr C vitamin degeri=" + portakal.VitaminC.ToString() + Environment.NewLine + "VitaminA=" + vitaminA.ToString() + " iu" + "   VitaminC=" + vitaminC.ToString()+ " mg";
                using (System.IO.StreamWriter dosya = new System.IO.StreamWriter("Hesaplamalar.txt", true))
                {
                    dosya.WriteLine("--Portakal hesaplamalari--");
                    dosya.WriteLine("Agirlik:" + agirlik);
                    dosya.WriteLine("Verim:" + verim);
                    dosya.WriteLine("Yeni Agirlik:" + yeniAgirlik);
                    dosya.WriteLine("Portakalda ki 100 gr A vitamin degeri=" + portakal.VitaminA);
                    dosya.WriteLine("Portakalda ki 100 gr C vitamin degeri=" + portakal.VitaminC);
                    dosya.WriteLine("VitaminA=" + vitaminA + " iu");
                    dosya.WriteLine("VitaminC=" + vitaminC + " mg");
                }
                textdosyasi.Text = File.ReadAllText(@"Hesaplamalar.txt");
                toplamA = toplamA + portakal.VitaminA;
                toplamC = toplamC + portakal.VitaminC;
                vitA.Text = toplamA.ToString();
                vitC.Text = toplamC.ToString();
            }

        }

       
    }
}
