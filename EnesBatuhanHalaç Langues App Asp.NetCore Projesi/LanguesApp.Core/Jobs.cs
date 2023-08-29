using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;


namespace LanguesApp.Core
{
    public static class Jobs
    {
        public static string GetUrl(string text)
        {
            #region Açıklama
            //Anlamak için kendi kendine açıkla:
            //Jobs Class'inin içerisindeki GetUrl Metodunun amaci Url Adresinin içerisindeki Latin Alfabesine Dönüştürülürken sorun yaratacak Türkçe Karakterlerin Latin Alfabesindeki karsitlari ile degistirilmesidir.
            //Örnek olarak ö=>o Ş=>S İ=>I gibi Ve Bosluklarin yerine - isareti gelecek (.)(,)(/)(;) gibi özel karakterler yok edilecek.
            //Amacimiz Url içerisinde Latin Alfabesi kurallarina uygun Küçük harflerden olusan bir Url Olusturmak.
            #endregion

            #region Url İçerisindeki Sorunlu Büyük karakterler küçük karaktere dönüştürülüyor.
            text.Replace("İ", "i");
            text.Replace("I", "i");
            text.Replace("ı", "i");
            text.Replace("Ç", "c");
            #endregion

            #region Diger Karakterler Kücük harfe dönüştürülüyor
            text.ToLower();
            #endregion

            #region Türkçe karakterler Latin Alfabesindeki karakterlere dönüştürülüyor.
            text.Replace("ü", "u");
            text.Replace("ö", "o");
            text.Replace("ş", "s");
            text.Replace("ç", "c");
            text.Replace("ğ", "g");
            #endregion

            #region Boşluklar - ye dönüştürülüyor.
            text.Replace(" ", "-");
            #endregion

            #region Sorunlu Özel Karakterler Kaldiriliyor
            text = text.Replace(".", "");
            text = text.Replace(",", "");
            text = text.Replace("/", "");
            text = text.Replace("\\", "");
            text = text.Replace("'", "");
            text = text.Replace("\"", "");
            text = text.Replace("^", "");
            text = text.Replace("#", "");
            text = text.Replace("$", "");
            text = text.Replace("%", "");
            text = text.Replace("&", "");
            text = text.Replace("{", "");
            text = text.Replace("(", "");
            text = text.Replace("[", "");
            text = text.Replace("]", "");
            text = text.Replace(")", "");
            text = text.Replace("}", "");
            text = text.Replace("*", "");
            text = text.Replace("=", "");
            text = text.Replace("?", "");
            text = text.Replace("_", "-");
            text = text.Replace("~", "");
            text = text.Replace("`", "");
            text = text.Replace("!", "");
            text = text.Replace("@", "");
            text = text.Replace(">", "");
            text = text.Replace("<", "");
            text = text.Replace("|", "");
            text = text.Replace("€", "");
            text = text.Replace("+", "");
            #endregion

            return text;
        }

        public static string CutText(string text,int length)
        {
            //substring metodu 2 parametre alabilir 1. parametre hangi sıradaki karakterden baslayacagi 2. parametre verilirse 2. parametre sırasıandaki karaktere kadar alir 2. parametre dahil degildir.
            return text.Substring(0, text.Length < length ? text.Length : 30);
        }

        public static List<int> GetAge(int startAge, int endAge)
        {
            List<int> ages = new List<int>();
            for(int i = startAge; i<=endAge; i++)
            {
                ages.Add(i);
            }
            return ages;
        }

        public static string UploadImage(IFormFile imageFile, string url, string dir)
        {
            var extension = Path.GetExtension(imageFile.FileName);

            var randomName = $"{url}-{Guid.NewGuid()}{extension}";

            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", dir, randomName);

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                imageFile.CopyTo(stream);
            }

            return randomName;

        }
    }
}
