namespace Odev2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("**ÖgrenciNotları**") ;


            Console.WriteLine("Vize Notunuzu Giriniz: ");
            int vize = int.Parse(Console.ReadLine());
            Console.WriteLine("Final Notunuzu Giriniz");
            int final = int.Parse(Console.ReadLine());

            int basariNotuvize = (vize * 40) / 100;
            int basariNotufinal = (final * 60) / 100;

            int sonuc = (basariNotuvize + basariNotufinal);


            if (sonuc>=60)
            {
                Console.WriteLine("Tebrikler Notunuz: {0}'dır Geçtiniz", sonuc);

            }
            else
            {
                Console.WriteLine("Üzgünüz Notunuz: {0}'dır.Kaldınız", sonuc);
            }

        }
    }
}