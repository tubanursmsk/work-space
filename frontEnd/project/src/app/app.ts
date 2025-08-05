import { Component, ChangeDetectionStrategy, ChangeDetectorRef } from '@angular/core'; //Component: Angular bileşeni tanımlamak için kullanılır. ChangeDetectionStrategy: Angular'ın değişiklikleri nasıl takip edeceğini belirler. ChangeDetectorRef: DOM’un elle güncellenmesi gerekirse kullanılır.
import { RouterOutlet } from '@angular/router';
import { Navbar } from './components/navbar/navbar';
import { Api } from './services/api';
import { lastValueFrom } from 'rxjs'; //lastValueFrom: RxJS Observable'ını Promise'e çevirir.

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, Navbar],
  templateUrl: './app.html',
  styleUrl: './app.css',
  changeDetection: ChangeDetectionStrategy.Default //ChangeDetectionStrategy.Default: Angular'ın varsayılan değişiklik algılama stratejisini kullanır. Bu, bileşenlerin değişikliklerini otomatik olarak takip eder.
})
export class App {
  protected title = 'project';
  tokenStatus = false //tokenStatus: Kullanıcının oturum durumunu tutar. true ise kullanıcı giriş yapmıştır.
  constructor(private api: Api, private cdr: ChangeDetectorRef) { //api: API servis çağrıları için kullanılır. cdr: Angular bileşenini elle yenilemek için kullanılır.
  this.authControl()// Bileşen oluşturulurken kullanıcı oturum durumu kontrol edilir.
  }

  async authControl() {
    try {
      const res = await lastValueFrom( this.api.userProfileSync() )
      if (res) {
        this.tokenStatus = true
        this.cdr.detectChanges();
      }
    } catch (error) {
      this.tokenStatus = false
      this.cdr.detectChanges();
    }
  }

}
/*Açıklama:
userProfileSync(): Kullanıcının token’ı geçerli mi, onu kontrol eden bir API çağrısıdır.
Eğer geçerliyse (res varsa):
tokenStatus = true
this.cdr.detectChanges() ile Angular manuel olarak DOM güncellenir.
Eğer hata olursa (token geçersiz, süresi dolmuşsa vs.):
tokenStatus = false olarak ayarlanır.
DOM tekrar güncellenir.

Özetle bu App bileşeni:
Uygulama başlatıldığında token geçerliliğini kontrol eder.
Eğer token geçerliyse, tokenStatus true olur.
Bu bilgi, navbar'da veya HTML içinde login/logout butonu göstermek için kullanılabilir.
ChangeDetectorRef sayesinde DOM manuel olarak yenilenir.
*/
