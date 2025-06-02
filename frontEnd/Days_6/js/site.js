//! Fonksiyon oluşturma
function showAlert(){
    alert("Show Alert")}

    
//! Değişken  oluşturma
//! var, let, const
var num1= 10 // daha sonra değeri değiştirebiliriz
num1 = 20

let num2 = 30 // let ile tanımlanan değişkenin değeri değiştirilebilir ama global olmayan değerlerdir
num2 = 40

let sum = num1 + num2
console.log("Sum:", sum);


var stName = "Ali"
let stSurname = "Bil"
function fnc1() {
    stName = "Ali"
    stSurname = "Bil"
}

fnc1()
console.log("stName:", stName); // stName değişkeni global değil, fnc1 içinde tanımlandı
console.log("stSurname:", stSurname); // stSurname değişkeni de global değil, fnc1 içinde tanımlandı


//Sabit değişken oluşturma
const address = "İstanbul" // sabit değişken, değeri değiştirilemez
// address = "Ankara" 
console.log("Address:", address); // Address: İstanbul


//Sellektörler
function getNameVal(){
    const name = document.getElementById('name') // id değeri name olan nesneyi buraya getir
    const nameVal = name.value

    const title = document.getElementById('appTitle')
    const titleVal = title.innerText
    console.log(nameVal, titleVal)
}

function pullList() {
    var html = ''
    var liHtml = ''
    const citiesArr = ['Ankara', 'İstanbul', 'İzmir', 'Bursa', 'Antalya', 'Adana']
    for (let i = 0; i < citiesArr.length; i++) {
        const item = citiesArr[i];
        const selected = item == 'İstanbul' ? 'selected': ''
        const active = item == 'İstanbul' ? 'active': ''
        html += '<option '+selected+' value="'+i+'">'+item+'</option>'
        liHtml += '<li class="list-group-item '+active+'">'+item+'</li>'
    }
    const citiesObj = document.getElementById('cities');
    const ulCitiesObj = document.getElementById('ulCities')
    citiesObj.innerHTML = html
    ulCitiesObj.innerHTML = liHtml
}