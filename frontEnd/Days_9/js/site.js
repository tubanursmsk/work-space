$(document).ready(function () {

    const accordionObj = $('#accordionExample')
    accordionObj.hide()
    var showStatus = false
    $('#btnShowHide').click(function (e) { 
        // accordionObj.show();  //.show() → aniden gösterir
        showStatus = !showStatus
        $(this).text(showStatus == true ? 'Hide': 'Show');
        //accordionObj.toggle();
        //accordionObj.fadeToggle(1000);   //.fadeToggle() → yavaşça opaklıkla gösterir/gizler
        accordionObj.slideToggle(500);   //slideToggle(500) → 0.5 saniyelik kayarak aç/kapat efekti uygulanır.
    });

    $('#box').click(function() {
        $('#box').animate(
            {width: '50px', height: '50px' }, 1000, function() {
                $('#box').animate({marginLeft: 100}, 500)
            }
        )
    })

    const inputObj = $('#inputData')
    const btnObj = $('#btnData')

    inputObj.after('<br/>');
    inputObj.val('New Data')  //val('New Data') → input’a otomatik olarak bu değer yazılır.
    inputObj.focus()  //focus() → sayfa açıldığında cursor otomatik olarak bu input alanına gelir.
    

});

/*
🧠 GENEL DEĞERLENDİRME
Özellik	Açıklama
.hide() / .show()	HTML öğesini gizler/gösterir
.text()	Buton metni gibi yazıyı değiştirmek için
.slideToggle()	Yavaşça açma/kapatma (akordeon efekti)
.animate()	CSS özelliklerini adım adım değiştirir (animasyon)
.val()	Input değerini alma/yazma
.focus()	İmleci input’a getirir
.after()	HTML öğesinin hemen sonrasına içerik ekler
*/