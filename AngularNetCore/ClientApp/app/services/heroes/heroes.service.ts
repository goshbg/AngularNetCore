import { Injectable } from '@angular/core'
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { Observable, of } from 'rxjs'
import { catchError } from 'rxjs/operators'

import { Hero } from '../../models/hero'

@Injectable()
export class HeroesService {
    constructor(private http: HttpClient) {

    }

    getHeroes(): Observable<Hero[]> {
        return this.http.get<Hero[]>("/api/heroes");
    }
}