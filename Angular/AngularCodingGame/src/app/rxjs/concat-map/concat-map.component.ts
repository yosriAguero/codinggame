import 'zone.js';
import { Component, OnInit } from '@angular/core';
import { bootstrapApplication } from '@angular/platform-browser';
import { Observable, of, Subscription, map,tap, concatMap } from 'rxjs';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-concatmap',
  standalone: true,
  imports: [CommonModule],
  template: `
   <ul>
     <li>si</li>
</ul>
  `,
})
export class ConcatMapComponentComponent  {

  //services









  sub!: Subscription;
  name = 'Angular';
  output!: any[];
}
export interface IPerson {
  name: string;
  lastname: string;
}
