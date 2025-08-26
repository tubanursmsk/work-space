import { Component, OnInit, ChangeDetectionStrategy, ChangeDetectorRef } from '@angular/core';
import { Api } from '../../services/api';
import { Pagination, Product, IProducts } from '../../models/IProducts';
import { ProductItem } from '../../components/product-item/product-item';
import { ActivatedRoute, RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms'; 
//import { Navbar } from '../../components/navbar/navbar';

@Component({
  selector: 'app-search',
  imports: [ProductItem, RouterModule, FormsModule],
  templateUrl: './search.html',
  styleUrl: './search.css',
  changeDetection: ChangeDetectionStrategy.Default
})
export class Search implements OnInit {

  isLoading = true
  productArr: Product[] = [] // Filtrelenmiş ürün listesini tutıyor
  originalProductArr: Product[] = []; // Orijinal ürün listesini tutmak için yeni değişken
  searchQuery: string = ''; 
   totalResults: number = 0;// Toplam sonuç sayısını tutıyor bu da 


  constructor( private api: Api, 
    private cdr: ChangeDetectorRef, 
    private activeRouter: ActivatedRoute)
    {}

  ngOnInit(): void {
    // URL'den arama terimini al ve veriyi çek
    this.activeRouter.queryParams.subscribe((params) => {
      this.searchQuery = params['q'] || '';
       if (this.searchQuery) {
        this.pullData();
      } else {
        this.productArr = [];
        this.totalResults = 0; // Arama terimi yoksa sonuç sayısını sıfırla
      }
      this.cdr.detectChanges();
    });
  }

  // Tüm ürünleri çeken metot
  pullData() {
    this.isLoading = true;
    this.productArr = [];
    // Sayfalama kullanmadan tüm ürünleri çektik yani ilk 70 ürünü
    this.api.allProducts(1, 70).subscribe({
      next: (value: IProducts) => {
        this.originalProductArr = value.data; 
        this.onSearch(); // Arama terimine göre filtreleme yap
      },
      error: (error) => {
        console.error('API isteği sırasında hata oluştu:', error);
      },
      complete: () => {
        this.isLoading = false;
        this.cdr.detectChanges();
      }
    });
  }

  // Arama çubuğuna girilen metinle listeyi filtreleme
  onSearch() {
    if (this.searchQuery.trim() === '') {
      this.productArr = []; // Arama terimi yoksa listeyi temizle
    } else {
      this.productArr = this.originalProductArr.filter(product => 
        product.title.toLowerCase().includes(this.searchQuery.toLowerCase())
      );
    }
     this.totalResults = this.productArr.length; // Sonuç sayısını güncelle
  }

}
