import { CommonModule } from '@angular/common';
import { Component, Input, OnChanges, SimpleChanges } from '@angular/core';
import { ProductService } from '../product.service';
import { Product } from '../product.model';
import { error } from 'console';

@Component({
  selector: 'app-product-detail',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './product-detail.component.html',
  styleUrl: './product-detail.component.css'
})
export class ProductDetailComponent implements OnChanges {

constructor(private productService: ProductService)
{

}


@Input() productId!: number ;
productDetail!: Product;
suppliersid! : number[];
ngOnChanges(changes: SimpleChanges): void {
 const id = changes['productId'].currentValue;
 if(id)
  {
      this.productService.getProductbyId(id).subscribe(
        {
        next: (pr)=>this.productDetail = pr,
        error: (err)=> console.error(err),
        complete:()=>console.log(this.productDetail)
        }
       
      );
  }
}
}


