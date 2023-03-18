//9) Değişken sayıda parametre alan carpim isminde bir fonksiyon tanımlayınız.

function carpim() {
  let sonuc = 0;
  for (let i = 0; i < arguments.length ; i++) {
    sonuc += arguments[i];
    // sonuc *= arguments[i];
  }
  return sonuc;
}
console.log(carpim(2,5,4,5,4));
