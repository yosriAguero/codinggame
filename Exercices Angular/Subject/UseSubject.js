import 'zone.js';
import { Component, Injectable, Input } from '@angular/core';
import { bootstrapApplication } from '@angular/platform-browser';
import { BehaviorSubject, Observable, of } from 'rxjs';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-second',
  standalone: true,
  template: `
  selected number :
    {{numberselected}}
  `,
})
export class AppSecond {
  name = 'AngularTwo';
  // @Input() numberselected: number | undefined = undefined;
  numberselected: number|undefined;
  constructor(private service: NumberService)
  {
    this.service.numberSerlected$.subscribe(n=>{
      this.numberselected = n;
    })
  }
}

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, AppSecond], // Import AppSecond here
  template: `
    <ul>
      <li *ngFor='let item of products$ | async' (click)="onSelected(item)"
      style="cursor: pointer;"> {{item}} </li>
</ul>
<!-- <app-second [numberselected] = "selectedproduct"></app-second> -->
<app-second></app-second>
  `,
})
export class App {
  name = 'Angular';
  products$ = this.service.getNumberObsevable();
  selectedproduct!: number;
  constructor(private service: NumberService) {}
  onSelected(item: number) {
    //this.selectedproduct = item;
    //use this time subject
    this.service.numberSelected(item);
  }
}

@Injectable({
  providedIn: 'root',
})
export class NumberService {
  private numberSelectedSubject = new BehaviorSubject<number | undefined>(
    undefined
  );
  //avoid accidentally override
  readonly numberSerlected$ = this.numberSelectedSubject.asObservable();

  numberSelected(selectedNumber: number) {
    this.numberSelectedSubject.next(selectedNumber);
  }

  getNumberObsevable(): Observable<number[]> {
    return of([1, 3, 5, 7]);
  }
}
bootstrapApplication(App);
