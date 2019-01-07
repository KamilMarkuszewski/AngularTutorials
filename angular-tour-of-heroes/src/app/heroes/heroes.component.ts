import { Component, OnInit } from '@angular/core';
import { Hero } from '../hero';
import { Heroes } from '../mock-heroes';
import { FormsModule } from '@angular/forms';
import { HeroService } from '../hero.service';

@Component({
  selector: 'app-heroes',
  templateUrl: './heroes.component.html',
  styleUrls: ['./heroes.component.css']
})
export class HeroesComponent implements OnInit {
  heroes: Hero[];
  selectedHero: Hero;

  hero : Hero = 
  {
    id: 1,
    name: "Deadpool"
  };

  constructor(private heroService : HeroService) { }

  ngOnInit() 
  {
    this.initHeroes();
  }

  initHeroes() : void
  {
    this.heroService.getHeroes().subscribe(h => this.heroes = h);
  }


  onSelect(hero: Hero): void {
    this.selectedHero = hero;
  }

}
