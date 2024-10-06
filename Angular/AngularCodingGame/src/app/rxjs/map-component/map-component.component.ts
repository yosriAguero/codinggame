import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { filter, from, map, mergeMap, Observable, of, pipe, tap, toArray } from 'rxjs';

@Component({
  selector: 'app-map',
  standalone: true,
  imports:[CommonModule],
  template: `
   <ul>
  <li *ngFor ="let item of outputArray">{{item.name}} {{item.profession}}  </li>
</ul>
  `,
})
export class MapComponentComponent implements OnInit {
  ngOnInit(): void {
    this.getPersonWithProperty().subscribe(
      {
         next:(result=>this.outputArray = result),
         error: (err=>console.error(err)),
         complete: ()=>console.log('done')
      }
    )
  }

    outputArray : any[] = [];



  getPersonWithProperty() 
  {
    return this.getPersonService().pipe(
     map((e)=>e.map(
      (p)=>({...p,'profession':'footballer'})
     )
    
    ),
    tap(
      (e)=>console.log('tap is ',e)
    ),
    mergeMap(
      (persons)=>from(persons)
    ),
    tap(
      (e)=>console.log('second tap is ',e)
    ),
    toArray()
    )
  }

V2()
{
  of(this.personArray).pipe(
    map(
      (persons=> persons.filter(p=>p.name.includes('g')))
    )
  )
}
  getPersonService():Observable<IPerson[]>
  {
    return of(this.personArray);
  }
  personArray: IPerson[] = [
    {name:'higuain',lastname:'gonzalo'},
    {name:'sergio',lastname:'aguero'}, {name:'leo',lastname:'messi'},
   
  ]



}

export interface IPerson
{
  name: string,
  lastname: string
}
