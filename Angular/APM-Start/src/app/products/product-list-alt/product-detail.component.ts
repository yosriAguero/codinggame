import { Component, Input, OnChanges, OnDestroy, OnInit, SimpleChanges } from '@angular/core';
import { Supplier } from '../../suppliers/supplier';
import { Product } from '../product';

import { ProductService } from '../product.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'pm-product-detail',
  templateUrl: './product-detail.component.html'
})
export class ProductDetailComponent implements OnInit,OnDestroy, OnChanges {
  pageTitle = 'Product Detail';
  errorMessage = '';
  product: Product | null = null;
  productSuppliers: Supplier[] | null = null;
  sub!: Subscription;
  @Input() productId! : number;
  constructor(private productService: ProductService) { }
  ngOnChanges(changes: SimpleChanges): void {
   const id = changes['productId'].currentValue;
   if(id)
    {
      this.sub = this.productService.getProductbyId(id).subscribe();
    }

  }
  ngOnDestroy(): void {
   this.sub.unsubscribe;
  }
  ngOnInit(): void {
   
  }



}
