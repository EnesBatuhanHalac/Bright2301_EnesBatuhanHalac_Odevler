   // 2. sorunun cevabı
   let meyveler = [];
   meyveler [0] = "Elma"
   meyveler [1] = "Armut"
   meyveler [2] = "Muz"
   meyveler [3] = "Çilek"

   let sonuc;
   
   sonuc=meyveler.length;    // dizinin  eleman sayısı.
   console.log("Toplam eleman sayısı:" ,sonuc, "ilk elemanı:",meyveler[0],"son elemanı:", meyveler[3]); // ilk ve son elemanı söyler.
   sonuc = meyveler.includes("Elma"); // elma kelimesisni dizi içinde //aradık ve bulduk.
   sonuc =meyveler.push("Kiraz"); // sonuna bi tane eleman ekledik //unshift de başına eklemek istersen kulalnılır.

  let silinenElemanlar;
  silinenElemanlar=meyveler.splice(3,4); // dizinin son 2 elemanını çıkardık.
   
  console.log(silinenElemanlar);

  
   
   let ad1 = "Kemal Devrimdar";
   let dogumYili1 = 2010;
   let not1 = [70,60,80];
   ogrenci1 = [ad1, dogumYili1, not1];

   let ad2 = "Saliha Temel";
   let dogumYili2 = 2012;
   let not2 = [80,80,90];
   ogrenci2 = [ad2, dogumYili2, not2];
   
   let ad3 = "Defne Küp";
   let dogumYili3 = 2009;
   let not3 = [60,60,70];
   ogrenci3 = [ad3, dogumYili3, not3];

   var toplam1 = 0; for (var i = 0; i < not1.length; i++) {
      toplam1 += not1[i];
      var ortalama1 = toplam1 / 3;
   }
   console.log("Öğrenci 1 notu toplam:", toplam1, "ortamala:" ,ortalama1);

    var toplam2 = 0; for (var i = 0; i < not1.length; i++) {
   toplam2 += not2[i];
    var ortalama2 = toplam2 / 3;}

  /*  var toplam2 = 0;
    var i = 0;
    do {
     toplam2 += not2[i];   bu da while yapılmış hali babba.
   
    i++;
    }while (i < not2.length)
    var ortalama2 = toplam2 / 3; */
      
   
   console.log("Öğrenci 2notu toplam:", toplam2, "ortamala:" ,ortalama2);

   var toplam3 = 0; for (var i = 0; i < not3.length; i++) {
      toplam3 += not3[i];
      var ortalama3 = toplam3 / 3;
   }
   console.log("Öğrenci 3 notu toplam:", toplam3, "ortamala:" ,ortalama3);

   console.log(` Öğrenci1: ${2023 - dogumYili1} yaşında `);
   console.log(` Öğrenci2: ${2023 - dogumYili2} yaşında `);
   console.log(` Öğrenci3: ${2023 - dogumYili3} yaşında `);
    
   let ogrenciler = [ogrenci1, ogrenci2, ogrenci3];

  console.log(ogrenciler);