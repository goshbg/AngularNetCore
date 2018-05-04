import { Component, OnInit } from '@angular/core';

import { Hero } from '../../models/hero'
import { HeroesService } from "../../services/heroes/heroes.service"

@Component({
    selector: 'app-heroes',
    templateUrl: './heroes.component.html',
    styleUrls: ['./heroes.component.css']
})

export class HeroesComponent implements OnInit
{
    heroes: Hero[];
    constructor(private heroesService: HeroesService)
    {

    }

    ngOnInit() {
        this.getHeroes();
    }

    getHeroes(): void {
        this.heroesService.getHeroes().subscribe(heroes => this.heroes = heroes);
    }
}
