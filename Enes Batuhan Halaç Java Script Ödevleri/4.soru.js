//       let sayilar = [1,5,7,15,3,25,12,24];

    //   1- sayilar listesindeki her bir elemanın karesini yazdırınız.
    //   2- sayilar listesindeki hangi sayılar 5' in katıdır?
    //   3- sayilar listesindeki çift sayıların toplamını bulunuz.

    //   let urunler = ["iphone 12","samsung s22","iphone 13","samsung s23","samsung s20"];

    //   4- urunler listesindeki tüm ürünleri büyük harf ile yazdırınız.
    //   5- urunler listesinde samsung geçen kaç ürün vardır?

    //   let ogrenciler = [
    //   {"ad":"yiğit", "soyad": "bilgi", "notlar": [60,70,60]},
    //   {"ad":"ada", "soyad": "bilgi", "notlar": [80,70,80]},
    //   {"ad":"çınar", "soyad": "turan", "notlar": [10,20,60]}
    //   ];

    let sayilar = [1,5,7,15,3,25,12,24];    // sayılar diye dizi oluşturduk.
    let sayilarinKareleri;
    //   1- sayilar listesindeki her bir elemanın karesini yazdırınız.
    sayilarinKareleri = sayilar.map(sayi => sayi * sayi); //map array nesnesinin methodlarından bi tanesidir, dizi içerisindeki tüm elemanları bir işlemden geçirmek için kullanılır. Her bir eleman tek tek işlenir.
    console.log(sayilarinKareleri); // dizideki her bir sayının karesini almış olduk.
    
    //    2- sayilar listesindeki hangi sayılar 5' in katıdır?
     let sayilarBeşinKati;
     let sonuc1;
     sayilarBeşinKati = sayilar.map(sayi => (sayi % 5 == 0));
     console.log("5 e bölünebilen tam sayılar:" +sayilarBeşinKati);
          

    //   3- sayilar listesindeki çift sayıların toplamını bulunuz.
     let sayilarIkininKati;
     let sonuc;
     for (var i = 0; i <= sayilar.length; i++) {
             if (i % 2 == 0 ) 
             {
                 sonuc +=i;
             }
         }
         
         console.log(sonuc);
