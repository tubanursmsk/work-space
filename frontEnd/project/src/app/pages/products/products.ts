import { Component, OnInit, ChangeDetectionStrategy, ChangeDetectorRef } from '@angular/core';
import { Api } from '../../services/api';
import { Pagination, Product } from '../../models/IProducts';
import { ProductItem } from '../../components/product-item/product-item';
import { ActivatedRoute, RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-products',
  imports: [ProductItem, RouterModule, FormsModule],
  templateUrl: './products.html',
  styleUrls: ['./products.css'],
  changeDetection: ChangeDetectionStrategy.Default
})
export class Products implements OnInit {

  isLoading = true;
  productArr: Product[] = [];
  originalProductArr: Product[] = []; // Orijinal ürün listesini tutmak için yeni değişken
  pageInfo: Pagination = {
    page: 0,
    per_page: 0,
    total_items: 0,
    total_pages: 0
  };
  pages: number[] = [];
  current_page = 1;

  searchQuery: string = ''; // ödev için yeni arama terimini tutacak değişken
 

  constructor(
    private api: Api,
    private cdr: ChangeDetectorRef,
    private activeRouter: ActivatedRoute
  ) {}

  ngOnInit(): void {
    this.activeRouter.queryParams.forEach((params) => {
      this.current_page = params['page'] || 1;
      this.pullData();
    });
  }

  pullData() {
    this.isLoading = true;
    this.productArr = [];
   this.api.allProducts(this.current_page, 10).subscribe({
      next: (value) => {
        // Orijinal listeyi doldur ve güncel listeye kopyala
        this.originalProductArr = value.data; 
        this.productArr = this.originalProductArr; 
        this.pageInfo = value.meta.pagination;
        this.pages = [];
        for (let i = 0; i < value.meta.pagination.total_pages; i++) {
          this.pages.push(i + 1);
        }
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
      this.productArr = this.originalProductArr;
    } else {
      this.productArr = this.originalProductArr.filter(product => 
        product.title.toLowerCase().includes(this.searchQuery.toLowerCase())
      );
    }
  }



  plus10Price() {
    this.productArr.forEach((item, index) => {
      setTimeout(() => {
        item.price = Number((item.price + 10).toFixed(2));
        this.cdr.detectChanges();
      }, index * 1500);
    });
  }
}