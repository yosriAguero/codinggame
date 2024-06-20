import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ProductRootComponent } from './producFolder/product-root.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,ProductRootComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'rxjsProject';
  
}
