/!SEÇİCİLER !/

//* jquery kodlarını $ işareti ile tetikleriz yani seçici $ işaretidir. 

//$(document).ready(function() {  }) -----> sayfanın yüklenmeye hazır olup olmadığını kontrol ediyor. Sayfa tamamen yüklendiğinde
//  bu kodlar çalışır

// $(document), bu kısım seçicinin içindeki döküman ya da js nin çalıştığı yer diyebiliriz bu projede index.htmldir. 
// jquery index.html'in en altına gömmüştük. döküman tamamlanır min.js jquery kodu okunur...
//.ready ise seciciye . operatörü ile yetenek kazandırıyoruz mesela burada okuma işlevi tanımlamışız.. 


//*  seçici (.) yetenek(.) function(){  }  
$(document).ready(function(){ //fonksiyonun amacıda dökümanda okuma sağlandıysa ne yapayım? 
   //alert("")
})

 // 1. seçici türü: nesneye göre seçim yapar 
 $('button').click(function(){  //Tüm <button> etiketleri tıklanınca çalışır
      //alert('button Submit') 
 })

 // 2. seçici türü: id'ye göre
 document.getElementById('submit') // id="submit" olan elemente tıklanınca çalışır. # işareti ile bir ID seçilir. örn. <button id="submit">Gönder</button>
 $('#submit').click(function(){
       //alert('Button Submit Call')
 })

// 3. seçici türü: class'a göre
 $('.form-label').click(function(){ //. ile sınıf (class) seçilir. Örneğin: <label class="form-label">E-mail</label>
       alert('Form Label Click')
 })

// 4. seçici türü: nesne içindeki özelliğe göre (,.#)
 $('.div-bg-dancer').click(function(){ //Bu örnekte hem bir <div> etiketi hem de class="div-bg-dancer" seçilmiştir. Daha gelişmiş seçimler için kullanılır (örneğin: div.bg-danger.active gibi).
       alert('Div Click')
 })

// 5. this seçici türü: hangi nesne seçili ise onun nesnesi üzerinden işlem yap. # işareti ile bir ID seçilir.
    $('div#box').click(function(){ //$(this), tıklanan nesnenin tam kendisi .toggleClass('bg-danger') → Bu yöntemle tıklanan div’in rengini değiştirmek gibi şeyler yapılabilir.
        $(this).toggleClass('bg-danger')
    })

// form submit
    $('#loginForm').submit(function (e) { //submit() → form gönderildiğinde çalışır.
        e.preventDefault();// formun sahneyi terk etmesini engeller. Sayfanın yeniden yüklenmesini engeller
        const email = $('#email').val() //$('#email').val() → e-posta input’unun değerini alır.
        const password = $('#password').val()
        const remember = $('#remember').is(':checked') //$('#remember').is(':checked') → checkbox seçili mi?
        const city = $('#city').val()
        console.log(email, password, remember, city) //Tüm değerler console.log() ile yazdırılır.
    });

 
    // change - değişim olduğunda bir sefer çalış
    //jqChange yaz ve enterla vscode  kalıbı hazır verir
    $('#email').change(function (e) {  //change() → bir input alanı değiştirildiğinde tetiklenir. Sadece odak dışına çıkıldığında çalışır. (blur)
        console.log("değişti")
    });

    const emails = [
        "alice.smith@gmail.com",
        "bob.johnson@yahoo.com",
        "carol.williams@hotmail.com",
        "david.brown@outlook.com",
        "ali@mail.com",
        "frank.miller@yahoo.com",
        "grace.davis@icloud.com",
        "henry.wilson@gmail.com",
        "irene.moore@hotmail.com",
        "jack.taylor@outlook.com"
    ];
    // değişim olduğunda her harf ile birlikte çalış
    $('#email').keyup(function (e) { 
        //console.log(e.target.value)
        if (e.originalEvent.key == 'Enter') {
            console.log('Enter Tıklanıldı')
        }
        const email = $(this).val()
        // var emailStatus = -1
        /*
        for (let i = 0; i < emails.length; i++) {
            const item = emails[i];
            if (item == email) {
                emailStatus = true
            }
        }
        */
        const emailStatus = emails.findIndex((item) => item == email)
        const answer = emailStatus > -1 ? 'Valid' : 'InValid'
        $('#emailHelp').text(answer);

        /*
        keyup() → her tuş basımından sonra tetiklenir.
        e.originalEvent.key == 'Enter' → kullanıcı Enter tuşuna bastı mı?
        $(this).val() → input içindeki güncel değeri alır.
        emails.findIndex(...) → girilen e-mail listedeki bir e-mail ile eşleşiyor mu?
        Eşleşme varsa emailStatus > -1, yoksa -1.
        Sonuç: #emailHelp öğesine "Valid" veya "InValid" yazısı yazılır.*/

    });

/*🧠 SONUÇ
Bu kod kümesi ile şunları öğrendin:

jQuery seçicileri (ID, class, tag, kombinasyon)

Form gönderimini yakalama ve değer alma

keyup, change, click gibi olaylar

this ile hedef elemana erişim

Basit bir input doğrulama (validation) mantığı
*/


