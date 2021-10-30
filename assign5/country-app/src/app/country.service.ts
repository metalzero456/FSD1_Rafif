import { Injectable } from '@angular/core';

import { Country } from './models/Country';
import { COUNTRIES } from './models/mock-country';
import { Observable, of } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root',
})
export class CountryService {
  countries = of(COUNTRIES);
  constructor() {}

  getCountry(): Observable<Country[]> {
    return this.countries;
  }

  getOneCountry(id: string): Observable<Country> {
    return this.countries.pipe(
      map((countries) => countries.filter((country) => country.id == id)[0])
    );
  }
}
