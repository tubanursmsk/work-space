import { CanActivateFn } from '@angular/router';

export const authGuard: CanActivateFn = (route, state) => {
  const stToken = localStorage.getItem('token')
    if (stToken) {
      return true
    }
    window.location.replace('/')
    return false
};

/*CanActivateFn sade ve fonksiyonel guard yazmanın modern yoludur (Angular 15+).

Token kontrolü yaparken mantığın doğru olması gerekir: token varsa true, yoksa false.

Yanlış: if (!token) return true → bu, yetkisiz kişiye izin vermek olur.

window.location.replace('/login') ile yönlendirme yapılabilir ama 
Angular’da Router.navigate() kullanmak daha doğrudur.*/