/*🧩 KOD KÜMESİNİN GENEL AMACI NEDİR?
Kullanıcı giriş formu (#formLogin) gönderildiğinde:

Sayfa yenilenmeden AJAX ile veriler sunucuya gönderilir

Başarılıysa kullanıcının adı ve JWT token alınır

Başarısızsa hata mesajı ekranda gösterilir
*/


$(document).ready(function () {  //Sayfa DOM yüklendiğinde içeriği çalıştırır.
    $('#message').hide()
    $('#formLogin').submit(function (e) { 
        e.preventDefault();  //Kullanıcının yazdığı email ve şifre değerleri alınır.
        $('#message').hide()  //Hata mesajı her form gönderiminde sıfırlanır (gizlenir).
        const email = $('#email').val() //Kullanıcının yazdığı email ve şifre değerleri alınır.


        const password = $('#password').val()
        
        // Ajax
        // url
        // sendData
        const url = 'https://jsonbulut.com/api/auth/login'  //İstek yapılacak API URL’si belirlenir ve Sunucuya gönderilecek veri sendObj içinde hazırlanır.
        const sendObj = {
            email: email,  //key: value
            password: password
        }

        $.ajax({
            type: "POST",  //type: "POST" → POST yöntemi kullanılır.
            url: url,  //url: isteğin gideceği adres
            data: sendObj,  //data: sunucuya gönderilecek form verileri
            dataType: "json",  //dataType: "json" → cevap formatı JSON bekleniyor
            success: function (response) {  //response objesi sunucudan gelen cevaptır.
                const name = response.data.user.name   //response.data.user.name → Kullanıcının adı
                const jwt = response.data.access_token  //response.data.access_token → Giriş sonrası dönen JWT Token
                console.log( name )  //Buraya kadar olan veriler genelde kullanıcıyı karşılama ve oturum açma işlemleri için kullanılır.


                console.log( jwt )
            },
            error: function (error) { //Sunucu bir hata cevabı verirse burası çalışır.
                //console.log(error.responseJSON.message)  
                //alert(error.responseJSON.message)  

                $('#message').slideDown()  //error.responseJSON.message içinde genellikle hata metni olur (örneğin: "Şifre hatalı").
                $('#message').text(error.responseJSON.message); //Bu mesaj #message kutusunda kullanıcıya gösterilir.
            }
        });

    });
});