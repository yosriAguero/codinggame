import { Component, OnDestroy, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { MergeStringComponent } from './merge-string/merge-string.component';
import { MapComponentComponent } from './rxjs/map-component/map-component.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,MergeStringComponent,MapComponentComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit,OnDestroy {

Hello!: string;

  constructor(){
    this.Hello = "Hello";
  }
  ngOnDestroy(): void {
 
  }
  ngOnInit(): void {
   
  }
  title = 'AngularCodingGame';

}
