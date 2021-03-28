using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
   public class Amac
    {
        private string AdSoyad;
        private ulong TCNo;
        private int odaNo;

    public string adsoyad
        {
            get { return AdSoyad; }
            set { AdSoyad = value; }
        }

    public ulong tcno
        {
            get { return TCNo; }
            set
            {
                if (value.ToString().Length == 11)

                    TCNo = value;
                else
                    Console.WriteLine("11 numaraya eşit olmalıdır.");
            }
        }
        public int odano
        {
            get { return odaNo; }
            set
            {
                if (value > 0 && value< 120)

                    odaNo = value;
                else
                    Console.WriteLine("rakam çok fazla");

            }
        }
            

    }
    class Program
    {
        static void Main(string[] args)
        {
         Amac p1 = new Amac();
            p1.adsoyad = "FIRAT YILDIZHAN";
            p1.tcno = 78849883044;
            p1.odano = 115;
            Console.WriteLine("adsoyad {0} , tcno {1} , odano {2}",p1.adsoyad,p1.tcno,p1.odano);
            Console.ReadLine();


        }
    }
}
