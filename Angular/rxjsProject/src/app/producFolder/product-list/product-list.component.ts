import { Component } from '@angular/core';
import { ProductService } from '../product.service';
import { EMPTY, Subscription, catchError, tap } from 'rxjs';
import { Product } from '../product.model';
import { CommonModule } from '@angular/common';
import { ProductDetailComponent } from '../product-detail/product-detail.component';

@Component({
  selector: 'app-product-list',
  standalone: true,
  imports: [CommonModule,ProductDetailComponent],
  templateUrl: './product-list.component.html',
  styleUrl: './product-list.component.css'
})
export class ProductListComponent  {


sub!: Subscription ;
selectedProductId! : number;
products$ = this.productservice.products$.pipe(
  tap(()=>console.log('pipeline')),
  catchError(err=>{
      console.error(err);
      return EMPTY;
})
);
  constructor(private productservice: ProductService)
  {
    
  }


  onSelected(arg0: number) {
   this.selectedProductId = arg0
   console.log(this.selectedProductId);
    }



}
