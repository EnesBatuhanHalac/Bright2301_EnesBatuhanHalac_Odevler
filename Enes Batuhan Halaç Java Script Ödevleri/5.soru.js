 //Kendisine gönderilen kelimeyi belirtilen kez ekranda yazan fonksiyonu yapınız.

 var mesaj;
 var sayi;
 mesaj = (prompt("Kelime yazınız."));
 sayi = parseInt(prompt("Kaç defa yazdırmak istersin yaz")); 
 for(var i = 1; i <= sayi; i++)
 {
    console.log('"',mesaj,'"', ",",i);
 }