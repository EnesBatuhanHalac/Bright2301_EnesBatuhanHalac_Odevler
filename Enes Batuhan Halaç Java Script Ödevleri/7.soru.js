 //7) Yazı tura uygulamasını(uygulama çalıştığında sonuç olarak ya yazı ya da tura diyecek) fonksiyon kullanarak yapınız.
 function yaziTuraAt() {
     let random = Math.random();
     if (random <= 0.5) {
       console.log("Yazı");
     } else {
       console.log("Tura");
     }
       console.log(random);
   }
   yaziTuraAt();
