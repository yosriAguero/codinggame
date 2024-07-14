import 'zone.js';
import { Component, OnInit } from '@angular/core';
import { bootstrapApplication } from '@angular/platform-browser';
import { Observable, of, Subscription, map } from 'rxjs';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule],
  template: `
   <ul>
     <li *ngFor="let item of output"> {{item?.name}} {{item.profession}}</li>
</ul>
  `,
})
export class App implements OnInit {
  ngOnInit(): void {
    const data$ = this.getData();

    this.sub = data$.subscribe({
      next: (res) => (this.output = res),
      error: (err) => console.error(err),
      complete: () => console.log(this.output),
    });
  }
  //services
  getData(): Observable<IPerson[]> {
    return of(this.personstab).pipe(
      map((persons: IPerson[]) =>
        persons.map((p: IPerson) => ({ ...p, profession: 'footballer' }))
      )
    );
  }
  personstab: IPerson[] = [
    { name: 'yosri', lastname: 'jabri' },
    { name: 'sergio', lastname: 'aguero' },
    { name: 'leo', lastname: 'messi' },
  ];
  sub!: Subscription;
  name = 'Angular';
  output!: any[];
}
export interface IPerson {
  name: string;
  lastname: string;
}
bootstrapApplication(App);
