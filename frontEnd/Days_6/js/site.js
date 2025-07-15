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
let stSurname = "Bil" //stName ve stSurname fonksiyon içinde tekrar değer ataması yapılarak güncelleniyor.
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
    var selectCity = 'İstanbul'
    const citiesArr = ['Ankara', selectCity, 'İzmir', 'Bursa', 'Antalya', 'Adana']
    for (let i = 0; i < citiesArr.length; i++) {
        const item = citiesArr[i];
        const selected = item == selectCity ? 'selected': ''
        const active = item == selectCity ? 'active': ''
        html += '<option '+selected+' value="'+i+'">'+item+'</option>'
        liHtml += '<li class="list-group-item '+active+'">'+item+'</li>'
    }
    const citiesObj = document.getElementById('cities');
    const ulCitiesObj = document.getElementById('ulCities')
    citiesObj.innerHTML = html
    ulCitiesObj.innerHTML = liHtml
    citiesObj.style.backgroundColor = 'lightblue'
}

function listReset() {
    const citiesObj = document.getElementById('cities');
    const ulCitiesObj = document.getElementById('ulCities')
    citiesObj.innerHTML = ''
    ulCitiesObj.innerHTML = ''
}

//object ---> JavaScript Nesnesi (Object) Oluşturma - getTable Fonksiyonu
function getTable() {
    const user1 = {
        id: 100,
        name: 'Ali',
        surname: 'Bilmem',
        email: 'ali@mail.com',
        status: true,
        colors: [
            "red", "black", "green"
        ],
        address: {
            city: 'İstanbul',
            area: 'Marmara',
            zip: 34400
        }
    }
    const arr = dataResult()  //dataResult() fonksiyonu ile rastgele 10 kullanıcı nesnesi oluşturuluyor.
    const newArr = arr.sort((a, b) => a.id - b.id)
    var html = ''
    for (let i = 0; i < newArr.length; i++) {
        const item = newArr[i];
        html += `
        <tr>
            <th scope="row">`+item.id+`</th>
            <td>`+item.name+`</td>
            <td>`+item.surname+`</td>
            <td>`+item.status+`</td>
            <td>`+item.age+`</td>
        </tr>`
    }
    const tableObj = document.getElementById('tableData')
    tableObj.innerHTML = html    
}

function dataResult() {
    var arr = []
    for (let i = 0; i < 10; i++) {
        const obj = {
            id: Math.round(Math.random() * 100),
            name: 'Name-'+i,
            surname: 'Surname-'+i,
            status: i %2 === 0 ? true : false,
            age: i
        }
        arr.push(obj) // dizi içine veri ekle
    }
    return arr
}
getTable()

