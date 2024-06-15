import { Component, OnInit, OnDestroy } from '@angular/core';

import { Subscription, map,tap } from 'rxjs';
import { ProductCategory } from '../product-categories/product-category';

import { Product } from './product';
import { ProductService } from './product.service';

@Component({
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit, OnDestroy {
  pageTitle = 'Product List';
  errorMessage = '';
  categories: ProductCategory[] = [];

  products: Product[] = [];
  sub!: Subscription;

  constructor(private productService: ProductService) { }

  ngOnInit(): void {
    this.sub = this.productService.getProducts().pipe(
      //map(pr=>({...pr,color:'red'})),
      tap((pr: any)=>console.log(pr))
    )
      .subscribe({
        next: products => this.products = products,
        error: err => this.errorMessage = err
      });
  }

  ngOnDestroy(): void {
    this.sub.unsubscribe();
  }

  onAdd(): void {
    console.log('Not yet implemented');
  }

  onSelected(categoryId: string): void {
    console.log('Not yet implemented');
  }
}
