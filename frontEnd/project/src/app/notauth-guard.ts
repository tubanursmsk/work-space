import { inject } from '@angular/core';
import { CanActivateFn } from '@angular/router'; //CanActivateFn: Bu bir guard fonksiyonu türüdür, route'a erişim verilip verilmeyeceğini belirler.
import { Api } from './services/api'; //Api: Uygulamadaki backend ile haberleşen servis (örneğin, userProfileSync() ile token doğrulama yapıyor).
import { lastValueFrom } from 'rxjs'; //lastValueFrom: RxJS'deki bir Observable'ı Promise'e çevirir. Yani await ile kullanılabilir hâle getirir.

export const notauthGuard: CanActivateFn = async (route, state) => { //Bu fonksiyon bir route'a erişmeden önce devreye girer. Asenkron çalışır (çünkü await var).
  const api = inject(Api); //api: Servis sınıfı (Api) enjekte ediliyor.
  const stToken = localStorage.getItem('token') //stToken: Kullanıcının localStorage'daki token'ı alınır. (Eğer giriş yaptıysa token vardır.)
  if (stToken) {
    try {
      const res = await lastValueFrom( api.userProfileSync() )
      if(res) {
        window.location.replace('/products')
        return false
      }
    } catch (error) {
      localStorage.removeItem('token')
      window.location.reload()
      return true
    }
  }
  return true
};
/*Açıklama:
Eğer token varsa, userProfileSync() çağrılır. Bu büyük olasılıkla sunucuda token geçerli mi diye kontrol eden bir API çağrısıdır.
Eğer geçerliyse (res dönüyorsa), kullanıcı /products sayfasına yönlendirilir. Çünkü zaten giriş yapmış biri login gibi sayfaya gitmemeli.
return false: Bu route'a geçilmesine izin verme anlamına gelir.
Eğer catch bloğuna düşerse (token geçersiz, sunucu hatası vs.):
token temizlenir.
Sayfa yenilenir.
Route'a geçmesine izin verilir (return true).
💡 Token Yoksa: kullanıcı zaten oturum açmamış demektir. Bu durumda route'a gitmesine izin verilir. Örneğin, /login ya da /register gibi.*/