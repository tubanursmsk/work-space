import { Routes } from '@angular/router';
import { Login } from './pages/login/login';
import { Register } from './pages/register/register';
import { Products } from './pages/products/products';
import { authGuard } from './auth-guard';
import { ProductDetail } from './pages/product-detail/product-detail';
import { notauthGuard } from './notauth-guard';
import { Notfound } from './pages/notfound/notfound';

export const routes: Routes = [
    {path: "", component: Login, canActivate: [notauthGuard]}, //Kullanıcı http://localhost:4200/ adresine gittiğinde Login sayfası yüklenir. Yani bu, varsayılan açılış sayfasıdır.
    {path: "register", component: Register}, //Kullanıcı http://localhost:4200/register adresine gittiğinde Register sayfası açılır.
    { path: "products", component: Products },
    { path: "products", component: Products, canActivate: [authGuard] },
    { path: "product-detail/:id", component: ProductDetail, canActivate: [authGuard] },
    { path: "**", component: Notfound}
  ];

/*Bu kod parçaları, Angular uygulamasında routing (yönlendirme) işlemlerini tanımlar. 
Angular’ın @angular/router modülü ile sayfa geçişlerini (SPA mantığında) kontrol edebilmeni sağlar.

📌 Satır Satır Açıklama:

 import { Routes } from '@angular/router';
--> Angular’ın yönlendirme sistemi için gerekli olan Routes tipini içe aktarır.
--> Routes bir dizi (array) tanımıdır ve her öğe bir yol (path) ile eşleşen bir bileşeni (component) temsil eder.

import { Login } from './pages/login/login';
--> Login bileşeni içe aktarılıyor. Bu bileşen ./pages/login/ klasörü içindeki login.ts dosyasından alınır.
--> Aynı şekilde Register bileşeni de içe aktarılıyor.
Not: Bu kodda LoginComponent yerine Login yazılmış. Bu, standalone component kullandığını gösteriyor
 (Angular 14+ ile gelen özellik). Eskiden bu bileşenler @NgModule içinde tanımlanırdı, artık
  doğrudan tanımlanabilir.

  export const routes: Routes = [...]
--> Bu, yönlendirme tanımlarını (path – component) içeren bir dizi (Routes) nesnesi oluşturur ve dışa aktarır.
--> Uygulamanın farklı yerlerinde kullanılmak üzere bu routes değişkeni dışa açılır.

*/