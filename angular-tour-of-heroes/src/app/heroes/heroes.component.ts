import { Component, OnInit } from '@angular/core';
import { Hero } from '../hero';
import { Heroes } from '../mock-heroes';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-heroes',
  templateUrl: './heroes.component.html',
  styleUrls: ['./heroes.component.css']
})
export class HeroesComponent implements OnInit {
  heroes = Heroes;
  selectedHero: Hero;

  hero : Hero = 
  {
    id: 1,
    name: "Deadpool"
  };

  constructor() { }

  ngOnInit() {
  }


  onSelect(hero: Hero): void {
    this.selectedHero = hero;
  }

}
