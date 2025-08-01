import { Component, ElementRef, ViewChild, ChangeDetectionStrategy, ChangeDetectorRef } from '@angular/core';
import { Bar } from '../../components/bar/bar';
import { FormsModule } from '@angular/forms';
import { Router, RouterModule } from '@angular/router';
import { emailValid, nameSurnameValid } from '../../utils/valids';
import { Api } from '../../services/api';

@Component({
  selector: 'app-register', //HTML içinde <app-register></app-register> şeklinde çağrılabilir.
  imports: [Bar, FormsModule, RouterModule],
  templateUrl: './register.html', // HTML şablon dosyası.
  styleUrl: './register.css', // Sayfa yönlendirmeleri için gerekli.
  changeDetection: ChangeDetectionStrategy.Default //herhangi bir model değişiminde otomatik güncelleme
})
export class Register {

  constructor(private router: Router, private api: Api, private cdr: ChangeDetectorRef){
    console.log("Register Call")
  }

  /*
@ViewChild Kullanımı
HTML şablonundaki #nameRef, #emailRef gibi referanslarla bağ kurar.
Odaklanmak (focus) gibi işlemleri doğrudan DOM üzerinden yapmak için kullanılır.
*/ 
  @ViewChild("nameRef")
  nameRef:ElementRef | undefined
  @ViewChild("emailRef")
  emailRef:ElementRef | undefined
  @ViewChild("passwordRef")
  passwordRef:ElementRef | undefined
  @ViewChild("passwordAgainRef")
  passwordAgainRef:ElementRef | undefined

  passlock = false //passlock: Şifrenin görünürlüğünü kontrol eder.
  passType = "password" //<input type="password"> ya da text olacak şekilde değiştirilir.
  error = '' //Geri bildirim mesajlarını tutar.
  success = '' //Geri bildirim mesajlarını tutar.

  // register values
  name = ''
  email = ''
  password = ''
  passwordAgain = ''

  // register fnc
  userRegister() {
    this.error = ''
    this.success = ''
    const nameData = nameSurnameValid(this.name)
    if (nameData === '') {
      this.error = 'Name / Surname not valid!'
      this.nameRef!.nativeElement.focus()
    }else if (!emailValid(this.email)) {
      this.error = 'Email not vali!'
      this.emailRef!.nativeElement.focus()
    }else if (this.password === '') {
      this.error = 'Password empty!'
      this.passwordRef!.nativeElement.focus()
    }else if (this.password.length < 8) {
      this.error = 'Password count min 8'
      this.passwordRef!.nativeElement.focus()
    }else if (this.password !== this.passwordAgain) {
      this.error = 'Password and Password Again not equals!'
      this.passwordAgainRef!.nativeElement.focus()
    }else {
      this.name = nameData
      // 1. javascript
      //window.location.href = '/'
      // 2. bir önceki ekrana dönüşü engelle
      //window.location.replace('/')
      // 3. Router ile geçiş - tavsiye
      //this.router.navigate(['/'], {replaceUrl: true, queryParams: {id: 10}})
      //this.router.navigate(['/'], {replaceUrl: true})
      this.api.userRegister(this.name, this.email, this.password).subscribe({
        next: (val) => {
          this.success = 'Register User Success'
          this.formReset()
          this.cdr.detectChanges()
          setTimeout(() => {
            this.router.navigate(['/'], {replaceUrl: true})
          }, 3000);
        },
        error: (err) => {
          this.error = 'E-Mail All ready in use!'
          this.cdr.detectChanges()
        }
      })
    }
  }
/* userRegister() Metodu

Formun gönderilmesiyle çalışır. 
**Aşamalar:
Hata ve başarı mesajları temizlenir.
**Doğrulama yapılır:
nameSurnameValid(this.name) → Ad ve soyad kontrolü
emailValid(this.email) → Geçerli e-posta kontrolü
**Şifre kontrolleri (boş mu, uzunluğu uygun mu, tekrar aynı mı)
Hatalıysa ilgili input'a focus() verilir.
**Her şey doğruysa:
this.api.userRegister(...) çağrılır.
**Başarılı olursa:
success mesajı gösterilir.
Form sıfırlanır.
3 saniye sonra ana sayfaya yönlendirilir.
**Başarısız olursa (örneğin e-posta zaten varsa):
Hata mesajı gösterilir.
detectChanges() ile DOM güncellenir. */


  // resetfnc -->  formReset(): Tüm inputları ve hata mesajlarını temizler.
  formReset(){
    this.name = ''
    this.email = ''
    this.password = ''
    this.passwordAgain = ''
    this.error = ''
  }

  // password text lock and unlock
  //Şifrenin görünürlüğünü aç/kapat işlevini sağlar. type="password" iken "text" yapar ve tam tersi...
  passwordLockUnLock() {
    this.passlock = !this.passlock
    this.passType = this.passlock === true ? 'text' : 'password'
  }

}
