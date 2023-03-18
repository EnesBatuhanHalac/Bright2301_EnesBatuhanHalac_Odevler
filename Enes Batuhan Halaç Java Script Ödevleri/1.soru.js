let url = "https://www.wissenakademie.com";
        let dersAdi = "Fullstack Web Developer Eğitimi";
        let karakterSayisi;
        let kelimeAdedi;
        let baslangic;
        let kelime;
        karakterSayisi = url.length; //url karakter sayısı.
        kelimeAdedi = dersAdi.split(" "); //dersAdi kaç kelimeden oluşur.
        baslangic = url.startsWith("https"); // url https ile başlıyomu.
        kelime = dersAdi.includes("Eğitimi"); // dersAdi içinde eğitimi kelimesi geçiyomu.
        

        let sonuc2;
        dersAdi = dersAdi.toLowerCase();
        dersAdi = dersAdi.replaceAll(" ","-");
        dersAdi = dersAdi.replace("Developer","gelistirme");
        sonuc2 = (`${url}/${dersAdi}`);
        console.log(sonuc2);

        //https://www.wissenakademie.com/fullstack-web-gelistirme-egitimi

        console.log("Karakter Sayısı:",karakterSayisi,"Kelime Adedi:",kelimeAdedi,"Url'nin Başlangıcı https ile başlar:",baslangic,"Ders Adı İçinde 'Eğitimi' kelimesi vardır:",kelime);