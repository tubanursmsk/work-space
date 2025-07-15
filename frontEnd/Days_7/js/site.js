function getData() {
    const url = 'https://jsonbulut.com/api/comments?page=1&per_page=10' //Amaç: Belirtilen URL'den yorum verilerini çekmek.
    const xhttp = new XMLHttpRequest() //XMLHttpRequest() klasik AJAX isteği için kullanılır.

    //burada getData fonksiyonu ve diğer yardımcı fonksiyonlar ile bir yorum listesini dış bir API’den çekip sayfada kartlar olarak göstermek, 
    // kullanıcı kartlara tıklayınca modal içinde detayları göstermek amaçlandı


    //Veriler geldiğinde yapılacak işlemler
    xhttp.onload = function() {
        const status = this.status  // HTTP durum kodu (örneğin: 200 OK) yani internet hareketi başarılı bir şekilde gerçekleştimi veriler doğru gitti mi bunu kontrol eder
        const statusText = this.statusText  // HTTP durum açıklaması
        const obj = JSON.parse(this.responseText)  // Gelen JSON verisini nesneye çevir
        cardData(obj.data)  // cardData(obj.data): Veriler işlenmek üzere cardData fonksiyonuna gönderilir.
    }

    xhttp.open('GET', url) // URL'ye GET isteği başlat
    xhttp.send()

}

function cardData(arr) { //Bu fonksiyonun amacı: arr (array) içindeki her bir yorum nesnesini (item) alıp, birer HTML kartına dönüştürmek.
    var html = ''  //html değişkeni bir metin (text) değişkenidir. JavaScript kodunun içinde HTML biçimindeki metni bu string içinde biriktiriyoruz. 
    for (let i = 0; i < arr.length; i++) {
        const item = arr[i];
        html += `
            <div onclick='selectComment(${JSON.stringify(item)})' class="col-sm-4 mb-3" role="button" data-bs-toggle="modal" data-bs-target="#exampleModal">
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-title">`+commentSubString(item.name, 10)+`</h5> 
                        <h6 class="card-subtitle mb-2 text-body-secondary">`+item.email+`</h6>
                        <p class="card-text">`+commentSubString(item.body, 50)+`</p>
                    </div>
                </div>
            </div>
        ` 
    }
    const commentsObj = document.getElementById('comments')
    commentsObj.innerHTML = html
}

function commentSubString(data, count) {
    const newData = data.substring(0, count)
    return newData
}

function selectComment({post_id, id, name, email, body}) {
    const titleObj = document.getElementById('exampleModalLabel')
    const commentBodyObj = document.getElementById('commentBody')
    const commnetEmailObj = document.getElementById('commnetEmail')
    titleObj.innerText = name
    commentBodyObj.innerText = body
    commnetEmailObj.innerText = email
}

getData()  //// Sayfa açıldığında otomatik olarak yorum verilerini al ve göster