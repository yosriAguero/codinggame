import 'zone.js';
import { Component, OnInit } from '@angular/core';
import { bootstrapApplication } from '@angular/platform-browser';
import { Observable, of, Subscription } from 'rxjs';
import { CommonModule } from '@angular/common';
@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule],
  template: `
   <div> 
     <ul>
       <li *ngFor="let item of output"> {{item}}</li>
</ul>
</div>
  `,
})
export class App implements OnInit {
  output!: string[];
  sub!: Subscription;
  ngOnInit(): void {
    const data$ = this.getData();

    this.sub = data$.subscribe({
      next: (result) => (this.output = result),
      error: (err) => console.error(err),
      complete: () => console.log('observer get a complete '),
    });
  }

  getData(): Observable<string[]> {
    const data = ['Angular', 'React', 'Vue'];
    return of(data);
  }

  name = 'Angular';
}

bootstrapApplication(App);
