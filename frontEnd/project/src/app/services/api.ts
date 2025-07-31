import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { userUrl, productUrl } from '../utils/apiUrl'; 
import { IUser } from '../models/IUser';
import { IProducts } from '../models/IProducts';

@Injectable({
  providedIn: 'root'
})
export class Api {

  constructor(private http: HttpClient) { }

  userLogin(email: string, password: string) {
    const sendObj = {
      email: email,
      password: password
    }
    return this.http.post<IUser>(userUrl.login, sendObj)
  }
  userRegister(name: string, email: string, password: string) {
    const sendObj = {
      name: name,
      email: email,
      password: password
    }
    return this.http.post(userUrl.register, sendObj)
  }

  allProducts(page: number, per_page: number) {
    const sendObj = {
      page: page,
      per_page: per_page
    }
    // Burada productUrl.products kullanıyoruz, bu da productUrl objesinin içinde "products" adında bir özelliğin olduğunu varsayar.
    return this.http.get<IProducts>(productUrl.products, {params: sendObj})
  }
  

  //**path variable -> https://jsonbulut.com/api/products/1
  productById(id: number){
    const url = `${productUrl.products + "/" + id}`
    

  }

}