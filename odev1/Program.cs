namespace odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***ÖGRENCİ NOTLARI****");

            Console.WriteLine("Vize Notunu Giriniz: ");
            int vize = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.WriteLine("Final Notunu Giriniz");
            int final = int.Parse(Console.ReadLine());

            int sonuc = (vize + final) / 2;



            Console.WriteLine("**SonuçEkranı**");

            if (sonuc >= 50)
            {
                Console.WriteLine("Notunuz: {0} Tebrikler Geçtiniz",sonuc);

            }
            else
            {
                Console.Write("Üzgünüz Notunuz {0} Kaldınız", sonuc);
            }




          
        }
    }
}