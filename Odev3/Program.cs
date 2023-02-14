namespace Odev3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int kare, kup;
            string istek;

            Console.WriteLine("Sayilarin Karesini Ve küpünü Hesaplama Programı");
            Console.WriteLine();

            Console.WriteLine("Sayının karesini hesaplamak istiyorsaniz kare, sayinin küpünü hesaplamak istiyor iseniz küp yaziniz Büyük Harf Kullanmayiniz!! : ");

            istek = Console.ReadLine();

            
            

            if (istek == "küp")
            {
                Console.WriteLine("Bir Sayi Degeri Giriniz: ");

                kup = Convert.ToInt32(Console.ReadLine());

                kup = kup * kup * kup ;

                Console.WriteLine("Giriş Yaptıgınız Sayi'nin Küpü: {0} dir.", kup);
            }


            else if (istek == "kare")
            {

                Console.WriteLine("Bir Sayi Degeri Giriniz: ");

                kare = Convert.ToInt32(Console.ReadLine());

                kare = kare * kare;

                Console.WriteLine("Giriş Yaptıgınız Sayi'nin Karesi: {0} dir.", kare);



            }
            
            else

            {


                Console.WriteLine("Yanlış Deger Girişi Tekrar Deneyiniz !!!");


            }







        }
    }
}