import { Component } from '@angular/core';
import { ProductService } from './product.service';
import { ProductListComponent } from './product-list/product-list.component';
import { ProductDetailComponent } from './product-detail/product-detail.component';

@Component({
  selector: 'app-product-root',
  standalone: true,
  imports: [ProductListComponent,ProductDetailComponent],
  templateUrl: './product-root.component.html',
  styleUrl: './product-root.component.css'
})
export class ProductRootComponent {

}
