using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    public interface IParaCekme
    {
        void cek();

    }
    public interface IparaYatirma
    {
        void yatir();
    }

    public class Ziraat : IParaCekme, IparaYatirma
    {
        public void cek()
        {
            Console.WriteLine("Bakiye Giriniz:");
            int bakiye = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Çekilecek ücret giriniz:");
            int cekilenmiktar = Convert.ToInt32(Console.ReadLine());
            bakiye -= cekilenmiktar;
            Console.WriteLine("Yeni Bakiyeniz"+bakiye);
        }

        public void yatir()
        {
            Console.WriteLine("Bakiye Giriniz:");
            int bakiye = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yatırılacak miktarı giriniz:");
            int yatirilanmiktar = Convert.ToInt32(Console.ReadLine());
            bakiye += yatirilanmiktar;
            Console.WriteLine("Yeni Bakiyeniz" + bakiye);
        }
    }
    public class Garanti : IParaCekme, IparaYatirma
    {
        public void cek()
        {
           
            Console.WriteLine("Bakiye Giriniz:");
            int bakiye = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Çekilecek ücret giriniz: Banka 2 tl işlem ücreti uygulayacaktır.");
            int cekilenmiktar = Convert.ToInt32(Console.ReadLine());
            bakiye = bakiye - cekilenmiktar;
            Console.WriteLine("Yeni Bakiyeniz" + (bakiye - 2));
        }

        public void yatir()
        {
            Console.WriteLine("Bakiye Giriniz:");
            int bakiye = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yatırılacak miktarı giriniz: Banka 2 tl işlem ücreti uygulayacaktır.");
            int yatirilanmiktar = Convert.ToInt32(Console.ReadLine());
            bakiye += yatirilanmiktar;
            Console.WriteLine("Yeni Bakiyeniz" + (bakiye-2));
        }
    }

}
