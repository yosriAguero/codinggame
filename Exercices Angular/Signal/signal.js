import 'zone.js';
import {Component, computed, signal} from '@angular/core';
import {bootstrapApplication} from '@angular/platform-browser';

@Component({
  selector: 'app-root',
  standalone: true,
  template: `
   {{c()}}
  `,
})
export class App {
  name = 'Angular';
  a = signal<number>(3);
  b = signal<number>(2);
  c= computed(()=> this.a() * this.b());
  constructor(){
    console.log(this.c());
    this.change();
    this.change2();
  
  }
  change()
  {
    this.b.set(3)
  }
  change2()
  {
    this.b.update((bb)=>bb*2);
  }

  
}

bootstrapApplication(App);
