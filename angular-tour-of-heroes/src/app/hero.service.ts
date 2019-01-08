import { Injectable } from '@angular/core';
import { Hero } from './hero';
import { Heroes } from './mock-heroes';
import { Observable, of } from 'rxjs';
import { MessageService } from './message.service';

@Injectable({
  providedIn: 'root',
})
export class HeroService {

  getHero(id: number): Observable<Hero> {
    this.messageService.add(`HeroService: fetcher hero id=${id}`);
    return of(Heroes.find(h => h.id === id));
  }

  constructor(private messageService: MessageService) { }

  getHeroes() : Observable<Hero[]>
  {
    this.messageService.add('HieroService: fetched heroes');
    return of(Heroes);
  }
  

}

