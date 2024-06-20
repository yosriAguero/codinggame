import { Component, OnDestroy, OnInit } from '@angular/core';
import { ProductService } from '../product.service';
import { Subscription } from 'rxjs';
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
export class ProductListComponent implements OnInit, OnDestroy {


sub!: Subscription ;
products!: Product[];
selectedProductId! : number;
  constructor(private productservice: ProductService)
  {
    
  }
  ngOnDestroy(): void {
    this.sub.unsubscribe();
  }
  ngOnInit(): void {
     this.sub =  this.productservice.getProducts().subscribe({
      next:(pr)=>{
        this.products = pr
      },
      error:(err)=>console.error(err),
     
    });
  
  }


  onSelected(arg0: number) {
   this.selectedProductId = arg0
   console.log(this.selectedProductId);
    }



}
