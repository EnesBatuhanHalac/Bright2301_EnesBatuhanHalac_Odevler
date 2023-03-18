1) Verilen url ve ders adı bilgisini kullanarak aşağıdaki işlemleri yapınız.
url="https://www.wissenakademie.com";
dersAdi="Fullstack Web Developer Eğitimi";
-url kaç karakterlidir?
-ders adı kaç kelimeden oluşmaktadır?
-url https ile başlıyor mu?
-ders adı içinde Eğitimi kelimesi geçiyor mu?
-url ve ders adını kullanarak aşağıdaki string ifadeyi oluşturun:
     https://www.wissenakademie.com/fullstack-web-gelistirme-egitimi
     

2) 

1- "Elma,Armut,Muz,Çilek" elemanlarına sahip bir dizi oluşturunuz.
2- Dizi kaç elemanlıdır?
3- Dizinin ilk ve son elemanı nedir?
4- Elma dizinin bir elemanımıdır?
5- Kiraz meyvesini listenin sonuna ekleyiniz.
6- Dizinin son 2 elemanını siliniz.
7- Aşağıdaki bilgileri dizi içerisinde saklayınız ve her öğrencinin yaşını ve not ortalamasını hesaplayınız.
    /*
        Öğrenci 1: Kemal Devrimdar 2010 (70,60,80)
        Öğrenci 2: Saliha Temel 2012   (80,80,90)
        Öğrenci 3: Defne Küp  2009 (60,60,70)
    */

3) 1- Aşağıdaki sipariş bilgilerini object içerisinde saklayınız.
    2- Her siparişin ayrı ayrı kdv dahil toplam ödenen ücretini hesaplayınız. (kdv: %18)
    3- Tüm siparişlerin kdv dahil toplam ödenen ücretini hesaplayınız.

    sipariş id: 101
    sipariş tarihi: 31.12.2022
    ödeme şekli: kredi kartı
    kargo adresi: Yahya kaptan mah. Kocaeli İzmit
    satın alınan ürünler: 
        ürün id: 5
        ürün başlığı: IPhone 13 Pro
        ürün url: http://abc.com/iphone-13-pro
        ürün fiyatı: 22000

        ürün id: 6
        ürün başlığı: IPhone 13 Pro Max
        ürün url: http://abc.com/iphone-13-pro-max
        ürün fiyatı: 25000

    müşteri:
        müşteri id: 12
        
    satıcı:
        firma id: 34
        firma adı: Apple Türkiye

    sipariş id: 102
    sipariş tarihi: 30.12.2022
    ödeme şekli: kredi kartı
    kargo adresi: Yahya kaptan mah. Kocaeli İzmit
    satın alınan ürünler: 

        ürün id: 6
        ürün başlığı: IPhone 13 Pro Max
        ürün url: http://abc.com/iphone-13-pro-max
        ürün fiyatı: 25000

    müşteri:
        müşteri id: 12
        
    satıcı:
        firma id: 34
        firma adı: Apple Türkiye

4) let sayilar = [1,5,7,15,3,25,12,24];

    1- sayilar listesindeki her bir elemanın karesini yazdırınız.
    2- sayilar listesindeki hangi sayılar 5' in katıdır?
    3- sayilar listesindeki çift sayıların toplamını bulunuz.

    let urunler = ["iphone 12","samsung s22","iphone 13","samsung s23","samsung s20"];

    4- urunler listesindeki tüm ürünleri büyük harf ile yazdırınız.
    5- urunler listesinde samsung geçen kaç ürün vardır?

    let ogrenciler = [
    {"ad":"yiğit", "soyad": "bilgi", "notlar": [60,70,60]},
    {"ad":"ada", "soyad": "bilgi", "notlar": [80,70,80]},
    {"ad":"çınar", "soyad": "turan", "notlar": [10,20,60]}
];

    6- ogrenciler listesindeki her öğrencinin not ortalaması ve başarı durumlarını yazdırınız.
    7- tüm öğrencilerin not ortalaması kaçtır?

5) Kendisine gönderilen kelimeyi belirtilen kez ekranda yazan fonksiyonu yapınız.

  Örnek kullanım: kelimeYazdir("merhaba", 2);

6) Dikdörtgenin alan ve çevresini hesaplayan fonksiyonu yazınız.

  Örnek kullanım: let sonuc = alanCevreHesapla(7, 10);

7) Yazı tura uygulamasını(uygulama çalıştığında sonuç olarak ya yazı ya da tura diyecek) fonksiyon kullanarak yapınız.

  Örnek kullanım: yaziTuraAt();

8) Kendisine gönderilen bir sayının tam bölenlerini dizi şeklinde döndüren fonksiyonu yazınız.

  Örnek kullanım: console.log(tamBolenler(10));    // 2, 5

9) Değişken sayıda parametre alan carpim isminde bir fonksiyon tanımlayınız.
   
10) Verilen bir metnin her sözcüğününün ilk harfleri büyük geri kalanları küçük hale dönüştürecek functionı hazırlayınız.