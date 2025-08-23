import { inject } from '@angular/core';
import {Api } from './services/api';
import { CanActivateFn } from '@angular/router';
import { Util } from './utils/util';

export const authGuard: CanActivateFn = (route, state) => { // Auth guard fonksiyonu
  const stToken = localStorage.getItem('token')
    if (stToken) { 
      const api = inject(Api) // Api servisini inject ediyoruz
      api.userProfile().subscribe({  // Kullanıcı profilini alıyoruz
        next: (user) => {
          const item = user.data as any
          Util.username = item.name
        },

        error: () => {
          localStorage.removeItem('token')
          window.location.replace('/')
        }
      });
      return true
    }
    else{
    window.location.replace('/')
    return false
    }
};

/*CanActivateFn sade ve fonksiyonel guard yazmanın modern yoludur (Angular 15+).

Token kontrolü yaparken mantığın doğru olması gerekir: token varsa true, yoksa false.

Yanlış: if (!token) return true → bu, yetkisiz kişiye izin vermek olur.

window.location.replace('/login') ile yönlendirme yapılabilir ama 
Angular’da Router.navigate() kullanmak daha doğrudur.*/